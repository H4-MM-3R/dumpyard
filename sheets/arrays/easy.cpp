#include <algorithm>
#include <climits>
#include <map>
#include <set>
#include <vector>

using namespace std;

/*
 * 1. Find the Largest element in an array
 */
int solve1(vector<int> arr) {
  int len = arr.size();
  int max = arr[0];
  for (int i = 1; i < len; i++) {
    if (arr[i] > max) {
      max = arr[i];
    }
  }

  return max;
}

/*
 * 2. Find Second smallest and largest element in an array
 */
pair<int, int> solve2(vector<int> arr) {
  int len = arr.size();
  if (len < 2)
    return {-1, -1};

  int smallest = INT_MAX;
  int second_smallest = INT_MAX;
  int largest = INT_MIN;
  int second_largest = INT_MIN;

  for (int i = 0; i < len; i++) {
    if (arr[i] < smallest) {
      second_smallest = smallest;
      smallest = arr[i];
    } else if (arr[i] < second_smallest && arr[i] != smallest) {
      second_smallest = arr[i];
    }

    if (arr[i] > largest) {
      second_largest = largest;
      largest = arr[i];
    } else if (arr[i] > second_largest && arr[i] != largest) {
      second_largest = arr[i];
    }
  }
  return {second_largest, second_smallest};
}

/*
 * 3. Check if an array is sorted
 */
bool solve3(vector<int> arr) {
  for (int i = 0; i < arr.size() - 1; i++) {
    if (arr[i] > arr[i + 1])
      return false;
  }
  return true;
}

/*
 * 4. Remove Duplicates in-place from a sorted array
 */
void solve4(vector<int> &arr) {
  int len = arr.size();
  int i = 0;
  while (i < len - 1) {
    if (arr[i] == arr[i + 1]) {
      arr.erase(arr.begin() + i);
      len--;
    } else {
      i++;
    }
  }
}
int solve4b(int arr[], int len) {
  int i = 0;
  for (int j = 1; j < len; j++) {
    if (arr[i] != arr[j]) {
      i++;
      arr[i] = arr[j];
    }
  }
  return i + 1;
}

/*
 * 5. Left Rotate an array one time
 */
void solve5(vector<int> &arr) {
  int len = arr.size();
  int temp = arr[0];
  for (int i = 0; i < len - 1; i++) {
    arr[i] = arr[i + 1];
  }
  arr[len - 1] = temp;
}

/*
 * 6. Rotate an array k times either left or right
 */
void reverse(vector<int> &arr, int start, int end) {
  while (start < end) {
    int temp = arr[start];
    arr[start++] = arr[end];
    arr[end--] = temp;
  }
}
void solve6(vector<int> &arr, int k) {
  // reversing the to the right
  reverse(arr, 0, arr.size() - k - 1);
  reverse(arr, arr.size() - k, arr.size() - 1);
  reverse(arr, 0, arr.size() - 1);
}

void solve6b(vector<int> &arr, int k) {
  // reversing the to the left
  reverse(arr, 0, k - 1);
  reverse(arr, k, arr.size() - 1);
  reverse(arr, 0, arr.size() - 1);
}

/*
 * 7. Move all the zeroes to the end of the array
 */
void swap(vector<int> &arr, int i, int j) {
  int temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
}
void solve7(vector<int> &arr) {
  int zero_ptr = arr.size() - 1;
  int non_zero_ptr = 0;
  while (zero_ptr > non_zero_ptr) {
    if (arr[non_zero_ptr] == 0) {
      while (arr[non_zero_ptr] == 0) {
        swap(arr, non_zero_ptr, zero_ptr--);
      }
    }
    non_zero_ptr++;
  }
}

/*
 * 8. Union of two sorted arrays
 */
vector<int> solve8(vector<int> arr1, vector<int> arr2) {

  // using Set
  set<int> ele_set;
  vector<int> union_arr;

  for (auto ele : arr1)
    ele_set.insert(ele);
  for (auto ele : arr2)
    ele_set.insert(ele);
  for (auto ele : ele_set)
    union_arr.push_back(ele);

  return union_arr;
}
vector<int> solve8b(vector<int> arr1, vector<int> arr2) {

  // using 2-Ptrs
  int i = 0, j = 0;
  vector<int> union_arr;

  while (i < arr1.size() && j < arr2.size()) {
    if (arr1[i] <= arr2[j]) {
      if (union_arr.size() == 0 || union_arr.back() != arr1[i]) {
        union_arr.push_back(arr1[i]);
      }
      i++;
    } else {
      if (union_arr.size() == 0 || union_arr.back() != arr2[j]) {
        union_arr.push_back(arr2[j]);
      }
      j++;
    }
  }

  while (i < arr1.size()) {
    if (union_arr.back() != arr1[i]) {
      union_arr.push_back(arr1[i]);
    }
    i++;
  }

  while (j < arr2.size()) {
    if (union_arr.back() != arr2[j]) {
      union_arr.push_back(arr2[j]);
    }
    j++;
  }

  return union_arr;
}

/*
 * 9. Find the missing number in an array
 */
int solve9(vector<int> arr) {
  int len = arr.size();
  int sum_of_arr = 0;
  int summation = ((len + 2) * (len + 1)) / 2;
  for (auto ele : arr) {
    sum_of_arr += ele;
  }
  if (sum_of_arr == summation) {
    return -1;
  }
  return summation - sum_of_arr;
}
int solve9b(vector<int> arr) {
  int len = arr.size();
  int xor_of_arr = 0;
  int xor_of_n = 0;
  for (auto ele : arr) {
    xor_of_arr ^= ele;
  }
  for (int i = 1; i < len + 2; i++) {
    xor_of_n ^= i;
  }
  if (xor_of_arr == xor_of_n) {
    return -1;
  }
  return xor_of_arr ^ xor_of_n;
}

/*
 * 10. Count maximum consecutive one's in an array
 */
int solve10(vector<int> arr) {
  int cnt = 0;
  int max_cnt = 0;
  for (int ele : arr) {
    if (ele == 1)
      cnt++;
    else
      cnt = 0;
    max_cnt = max(max_cnt, cnt);
  }
  return max_cnt;
}

/*
 * 11. Find the element that appears once in an array out of all the double
 * elements
 */
int solve11(vector<int> arr) {
  map<int, int> mp;
  for (int ele : arr) {
    mp[ele]++;
  }
  for (int ele : arr) {
    if (mp.find(ele) != mp.end() && mp[ele] == 1) {
      return ele;
    }
  }
  return -1;
}
int solve11b(vector<int> arr) {
  int ans = 0;
  for (int ele : arr) {
    ans ^= ele;
  }
  return ans;
}

/*
 * 12. Longest Subarray with sum K
 */
int solve12(vector<int> arr, int k) {
  map<long long, int> pref_sum_mp;
  long long sum = 0;
  int max_len = 0;
  for (int i = 0; i < arr.size(); i++) {

    sum += arr[i];

    long long rem_sum = sum - k;

    if (pref_sum_mp.find(rem_sum) != pref_sum_mp.end()) {
      max_len = max(max_len, i - pref_sum_mp[rem_sum]);
    }
    if (pref_sum_mp.find(sum) == pref_sum_mp.end()) {
      pref_sum_mp[sum] = i;
    }
  }
  return max_len;
}
int solve12b(vector<int> arr, int k) {
  int len = arr.size();
  int left = 0, right = 0;
  long long sum = arr[0];
  int max_len = 0;
  while (right < len) {

    while (left <= right && sum > k) {
      sum -= arr[left];
      left++;
    }

    if (sum == k) {
      max_len = max(max_len, right - left + 1);
    }

    right++;
    if (right < len)
      sum += arr[right];
  }
  return max_len;
}

/*
 * 13. longest subarray with sum k (+ve and -ve numbers)
 */
int solve13(vector<int> arr, int k) {
  int len = arr.size();

  int ans = 0;
  for (int i = 0; i < len; i++) {
    int sum = 0;
    for (int j = i; j < len; j++) {
      sum += arr[j];
      if (sum == k)
        len = max(len, j - i + 1);
    }
  }

  return ans;
}
int solve13b(vector<int> arr, int k) {
  int len = arr.size();
  map<int, int> pref_sum_mp;
  int sum = 0;
  int max_len = 0;
  for (int i = 0; i < len; i++) {
    sum += arr[i];
    
    if(sum == k) max_len = max(max_len, i + 1);

    long long rem_sum = sum - k;

    if (pref_sum_mp.find(rem_sum) != pref_sum_mp.end()) {
      max_len = max(max_len, i - pref_sum_mp[rem_sum]);
    }

    if(pref_sum_mp.find(sum) == pref_sum_mp.end()){
        pref_sum_mp[sum] = i;
    }
  }
  return max_len;
}

int main() {
}
