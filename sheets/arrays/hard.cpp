#include <algorithm>
#include <climits>
#include <iostream>
#include <set>
#include <unordered_map>
#include <vector>

using namespace std;

// Helpers
void arr_printer(vector<int> arr) {
  for (int ele : arr) {
    cout << ele << " ";
  }
  cout << endl;
}

void matrix_printer(vector<vector<int>> arr) {
  for (int i = 0; i < arr.size(); i++) {
    for (int j = 0; j < arr[i].size(); j++) {
      cout << arr[i][j] << " ";
    }
    cout << endl;
  }
}

/*
 * 1. Pascal's triangle applications
 */
int nCr(int n, int r) {
  long long res = 1;

  for (int i = 0; i < r; i++) {
    res *= (n - i);
    res /= (i + 1);
  }
  return (int)res;
}

int solve1(int r, int c) {
  // Variation 1: given row and column, find the value in pascal's triangle
  return nCr(r - 1, c - 1);
}

void solve1b(int n) {
  // Variation 2: given row 'n', print the entire row of pascal's triangle
  for (int i = 1; i <= n; i++) {
    cout << nCr(n - 1, i - 1) << " ";
  }
  cout << endl;
}

void solve1c(int n) {
  // Variation 3: given row 'n', print pascal's triangle till row 'n'
  vector<vector<int>> ans;

  for (int row = 1; row <= n; row++) {
    for (int i = 0; i < n - row; i++) {
      cout << " ";
    }
    for (int col = 1; col <= row; col++) {
      cout << nCr(row - 1, col - 1) << " ";
    }
    cout << endl;
  }
}

/*
 * 2. Find the elements that appears more than N / 3 times in an array
 */
vector<int> solve2(vector<int> arr) {
  int n = arr.size();
  vector<int> ans;
  unordered_map<int, int> mp;

  for (int ele : arr) {
    mp[ele]++;
  }
  for (auto it : mp) {
    if (it.second > n / 3) {
      ans.push_back(it.first);
    }
  }
  return ans;
}

vector<int> solve2b(vector<int> arr) {
  // Extended version of Moore's Voting algorithm

  int n = arr.size();
  vector<int> ans;

  int ele1 = INT_MIN, ele2 = INT_MIN;
  int cnt1 = 0, cnt2 = 0;

  for (int ele : arr) {
    if (cnt1 == 0 && ele != ele2) {
      cnt1 = 1;
      ele1 = ele;
    } else if (cnt2 == 0 && ele != ele1) {
      cnt2 = 1;
      ele2 = ele;
    } else if (ele == ele1)
      cnt1++;
    else if (ele == ele2)
      cnt2++;
    else {
      cnt1--;
      cnt2--;
    }
  }

  cnt1 = 0, cnt2 = 0;
  for (int ele : arr) {
    if (ele == ele1)
      cnt1++;
    else if (ele == ele2)
      cnt2++;
  }
  if (cnt1 > n / 3)
    ans.push_back(ele1);
  if (cnt2 > n / 3)
    ans.push_back(ele2);

  return ans;
}

/*
 * 3. Three Sum
 */
vector<vector<int>> solve3(vector<int> arr) {
  set<vector<int>> ans;

      set<int> st;
  for (int i = 0; i < arr.size(); i++) {
    for (int j = i + 1; j < arr.size(); j++) {
      int k = -(arr[i] + arr[j]);
      if (st.find(k) != st.end()) {
        vector<int> temp = {arr[i], arr[j], k};
        sort(temp.begin(), temp.end());
        ans.insert(temp);
      }
    }
    st.insert(arr[i]);
  }

  return vector<vector<int>>(ans.begin(), ans.end());
}

vector<vector<int>> solve3b(vector<int> arr) {
  int n = arr.size();
  vector<vector<int>> ans;
  sort(arr.begin(), arr.end());
  for (int i = 0; i < n; i++) {
    if (i != 0 && arr[i] == arr[i - 1])
      continue;

    int j = i + 1;
    int k = n - 1;

    while (j < k) {
      int sum = arr[i] + arr[j] + arr[k];
      if (sum < 0)
        j++;
      else if (sum > 0)
        k--;
      else {
        vector<int> temp = {arr[i], arr[j], arr[k]};
        ans.push_back(temp);
        j++;
        k--;

        while (j < k && arr[j] == arr[j - 1])
          j++;
        while (j < k && arr[k] == arr[k + 1])
          k--;
      }
    }
  }
  return ans;
}

int main() {
  vector<int> arr = {1, 2, -3, -2, 4, -2, -1};
  matrix_printer(solve3b(arr));
  cout << endl;
  matrix_printer(solve3(arr));
}
