#include <algorithm>
#include <climits>
#include <iostream>
#include <unordered_set>
#include <utility>
#include <vector>


using namespace std;

void ap(vector<int> arr) {
  for (int i = 0; i < arr.size(); i++) {
    cout << arr[i] << " ";
  }
  cout << endl;
}

void swap(vector<int> &arr, int i, int j) {
  int temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
}

/*
 * 1. Two Sum
 */
bool solve1(vector<int> arr, int target) {
  unordered_map<int, int> mp;
  for (int i = 0; i < arr.size(); i++) {
    int other_num = target - arr[i];
    if (mp.find(other_num) != mp.end()) {
      return true;
    } else {
      mp[arr[i]] = i;
    }
  }
  return false;
}
bool solve1b(vector<int> arr, int target) {
  sort(arr.begin(), arr.end());
  int len = arr.size();
  int left = 0, right = len - 1;
  while (left < right) {
    int sum = arr[left] + arr[right];
    if (sum == target)
      return true;
    else if (sum < target)
      left++;
    else
      right--;
  }
  return false;
}

/*
 * 2. Sort an array of 0s, 1s and 2s
 */
void solve2(vector<int> &arr) {
  int zero = 0, one = 0, two = 0;
  for (int ele : arr) {
    if (ele == 0)
      zero++;
    else if (ele == 1)
      one++;
    else if (ele == 2)
      two++;
  }
  arr.clear();
  for (int i = 0; i < zero; i++)
    arr.push_back(0);
  for (int i = 0; i < one; i++)
    arr.push_back(1);
  for (int i = 0; i < two; i++)
    arr.push_back(2);
}

void solve2b(vector<int> &arr) {
  // Dutch National Flag algorithm
  int len = arr.size();
  int zero = 0, one = 0, two = len - 1;
  while (one <= two) {
    if (arr[one] == 0) {
      swap(arr, one, zero);
      zero++;
      one++;
    } else if (arr[one] == 1) {
      one++;
    } else {
      swap(arr, one, two);
      two--;
    }
  }
}

/*
 * 3. Find the majority element that occurs more than N / 2 times
 */
int solve3(vector<int> arr) {
  int len = arr.size();
  unordered_map<int, int> mp;
  for (int ele : arr) {
    mp[ele]++;
    if (mp[ele] > len / 2) {
      return ele;
    }
  }
  return -1;
}
int solve3b(vector<int> arr) {
  // Moore's Voting Algorithm

  int maj_ele = 0;
  int maj_cnt = 0;
  for (int ele : arr) {
    if (maj_cnt == 0)
      maj_ele = ele;
    if (maj_ele == ele)
      maj_cnt++;
    else
      maj_cnt--;
  }
  return maj_ele;
}

/*
 * 4. Maximum subarray sum in an array
 */
int solve4(vector<int> arr) {
  // Kadane's Algorithm

  int maxi = INT_MIN;
  int sum = 0;
  for (int ele : arr) {
    sum += ele;

    if (sum > maxi)
      maxi = sum;
    if (sum < 0)
      sum = 0;
  }
  return maxi;
}

int solve4b(vector<int> arr) {
  // Follow up: There might be more than one subarray that has the largest sum.
  // so print any of the subarrays too.
  int maxi = INT_MIN;
  int sum = 0, ptr = 0, start = -1, end = -1;

  for (int i = 0; i < arr.size(); i++) {
    if (sum == 0)
      ptr = i;
    sum += arr[i];

    if (sum > maxi) {
      maxi = sum;
      start = ptr;
      end = i;
    }

    if (sum < 0)
      sum = 0;
  }
  cout << "[";
  for (int i = start; i <= end; i++) {
    cout << arr[i] << " ";
  }
  cout << "]\n";
  return maxi;
}

/*
 * 5. Stock buy and sell
 */
int solve5(vector<int> arr) {
  int max_profit = 0;
  int min_price = INT_MAX;
  for (int ele : arr) {
    min_price = min(min_price, ele);
    max_profit = max(max_profit, ele - min_price);
  }
  return max_profit;
}

/*
 * 6. Rearrange array elements by alternating signs
 */
vector<int> solve6(vector<int> &arr) {
  int n = arr.size();
  vector<int> ans(n, 0);
  int pos_ptr = 0, neg_ptr = 1;
  for (int i = 0; i < n; i++) {
    if (arr[i] < 0) {
      ans[neg_ptr] = arr[i];
      neg_ptr += 2;
    } else {
      ans[pos_ptr] = arr[i];
      pos_ptr += 2;
    }
  }
  return ans;
}
vector<int> solve6b(vector<int> &arr) {
  // variation: if no of negative and positive elements are unequal
    vector<int> pos;
    vector<int> neg;

    for(int ele : arr){
        if(ele < 0) neg.push_back(ele);
        else pos.push_back(ele);
    }
    int pos_index = pos.size();
    int neg_index = neg.size();

    if(pos_index < neg_index){
        for(int i = 0; i < pos_index; i++){
            arr[2*i] = pos[i];
            arr[2*i+1] = neg[i];
        }

        int index = pos_index * 2;
        for(int i = pos_index; i < neg_index; i++){
            arr[index] = neg[i];
            index++;
        }
    } else {
        for(int i = 0; i < neg_index; i++){
            arr[2*i] = pos[i];
            arr[2*i+1] = neg[i];
        }

        int index = neg_index * 2;
        for(int i = neg_index; i < pos_index; i++){
            arr[index] = pos[i];
            index++;
        }
    }

    return arr;
}

/*
 * 7. Find the next lexicographically greater permutation
 */
vector<int> solve7(vector<int> &arr){
    int len = arr.size();

    int idx = -1;                           // index of the Pivot
                  
                  
    for(int i = len - 2; i >= 0; i--){     // find the Pivot
        if(arr[i] > arr[i + 1]){
            idx = i;
            break;
        }
    }

    if(idx == -1){
        reverse(arr.begin(), arr.end());    // if no Pivot found, reverse the array (largest permutation)
        return arr;
    }

    for(int i = len - 1; i > idx; i--){    // swap pivot with the next greatest element.
        if(arr[i] > arr[idx]){
            swap(arr[i], arr[idx]);
            break;
        }
    }

    reverse(arr.begin(), arr.end());

    return arr;
}

/*
 * 8. Print all the " Leader " Elements
 *
 * Leader: element greater than all the 
 */

vector<int> solve8(vector<int> arr){
    vector<int> ans;

    int len = arr.size();
    ans.push_back(arr[len - 1]);
    for(int i = len - 2; i > 0; i--){
        if(ans.back() < arr[i]){
            ans.push_back(arr[i]);
        }
    }
    return ans;
}

/*
 * 9. Find the length of the longest sequence which contains the consecutive elements.
 */
int solve9(vector<int> arr){
    sort(arr.begin(), arr.end());
    int last_smaller = INT_MIN;
    int cnt = 0;
    int ans = 1;

    for(int ele: arr){
        if(ele - 1 == last_smaller){
            cnt++;
            last_smaller = ele;
        } else if(ele != last_smaller){
            last_smaller = ele;
            cnt = 1;
        }
        ans = max(ans, cnt);
    }
    return ans;

}

int solve9b(vector<int> arr){
    // using hashing

    unordered_set<int> st;

    for(int ele: arr) st.insert(ele);

    int ans = 1;
    for(int ele: arr){                      // ele - 1 is the previous consecutive element
        if(st.find(ele - 1) == st.end()){   // ele - 1 doesn't exist in set then it might be 
            int cnt = 1;                    // the first consecutive element
            int x = ele;
            while(st.find(x + 1) != st.end()){
                x++;
                cnt++;
            }
            ans = max(ans, cnt);
        }
    }
    return ans;
}

int main() {
    vector<int> arr = {100, 200, 1, 2, 3, 4};
    cout << solve9b(arr); 
}
