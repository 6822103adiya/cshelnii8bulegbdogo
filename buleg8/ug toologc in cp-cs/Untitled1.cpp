#include <iostream>
#include <string>

using namespace std;

int main() {
    string word;
    cout << "ug oruul: ";
    cin >> word;
    
    int count = 0;
    for (int i = 0; i < word.length(); i++) {
        count++;
    }
    
    cout << "niit ugiin too: " << count << endl;
    
    return 0;
}

