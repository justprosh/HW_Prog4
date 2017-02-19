#include <iostream>
#include <fstream>

int maxNyam(int **a, bool **b, int x, int y) {
	int max = 0;
	int cur = 0;
	if (x > 1 && y > 1 && a[x - 1][y - 1] == 2 && !b[x - 1][y - 1] && a[x - 2][y - 2] == 0) {
		b[x - 1][y - 1] = true;
		max += 1 + maxNyam(a, b, x - 2, y - 2);
		b[x - 1][y - 1] = false;
	}
	if (y < 6 && x > 1 && a[x - 1][y + 1] == 2 && !b[x - 1][y + 1] && a[x - 2][y + 2] == 0) {
		b[x - 1][y + 1] = true;
		cur = 1 + maxNyam(a, b, x - 2, y + 2);
		max = cur > max ? cur : max;
		b[x - 1][y + 1] = false;
	}
	if (y > 1 && x < 6 && a[x + 1][y - 1] && !b[x + 1][y - 1] && a[x + 2][y - 2] == 0) {
		b[x + 1][y - 1] = true;
		cur = 1 + maxNyam(a, b, x + 2, y - 2);
		max = cur > max ? cur : max;
		b[x + 1][y - 1] = false;
	}
	if (y < 6 && x < 6 && a[x + 1][y + 1] == 2 && !b[x + 1][y + 1] && a[x + 2][y + 2] == 0) {
		b[x + 1][y + 1] = true;
		cur = 1 + maxNyam(a, b, x + 2, y + 2);
		max = cur > max ? cur : max;
		b[x + 1][y + 1] = false;
	}
	return max;
}

int main() {
	int x, y, n, x1, y1;
	std::ifstream fin("Input.txt");
	std::ofstream fout("Output.txt");
	int **a = new int*[8];
	bool **b = new bool*[8];
	for (int i = 0; i < 8; i++) {
		a[i] = new int[8];
		b[i] = new bool[8];
		for (int j = 0; j < 8; j++) {
			a[i][j] = 0;
			b[i][j] = false;
		}
	}
	fin >> x >> y;
	a[x - 1][y - 1] = 1;
	fin >> n;
	for (int i = 0; i < n; i++) {
		fin >> x1 >> y1;
		a[x1 - 1][y1 - 1] = 2;
	}
	int max = maxNyam(a, b, x - 1 , y - 1);
	for (int i = 0; i < 8; i++) {
		delete[] a[i];
		delete[] b[i];
	}
	fout << max;
	fin.close();
	delete[] a;
	delete[] b;
	return 0;
}
