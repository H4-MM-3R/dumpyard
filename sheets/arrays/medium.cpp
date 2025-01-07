#include <algorithm>
#include <array>
#include <climits>
#include <iostream>
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
    for(int ele: arr){
        sum += ele;

        if(sum > maxi) maxi = sum;
        if(sum < 0) sum = 0;
    }
    return maxi;
}

int solve4b(vector<int> arr) {
    // Follow up: There might be more than one subarray that has the largest sum. so print any of the subarrays too.
    int maxi = INT_MIN;
    int sum = 0, ptr = 0, start = -1, end = -1;

    for(int i = 0; i < arr.size(); i++){
        if(sum == 0) ptr = i;
        sum += arr[i];

        if(sum > maxi){
            maxi = sum;
            start = ptr;
            end = i;
        }

        if(sum < 0) sum = 0;
    }
    cout << "[";
    for(int i = start; i <= end; i++){
        cout << arr[i] << " ";
    }
        cout << "]\n";
    return maxi;
}


int main() {
  vector<int> arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4};
  cout << solve4b(arr);
}
