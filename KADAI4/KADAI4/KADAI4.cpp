﻿// KADAI4.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include "pch.h"
#include<vector>
#include <iostream>
using namespace std;
int poly3(int x, int a, int n);
int main()
{
	int X=0;
	int N=0;
	int A=0;
	printf("Xの値の入力");
	scanf_s("%d",X);
	printf("Aの値の入力");
	scanf_s("%d",A);
	printf("Nの値の入力");
	scanf_s("%d",N);
	

	poly3(X,A,N);
}
int poly3(int x, int a, int n)
{
	vector<int> v = {};

	for (int i = 0; i < n; i++) {
		 v[i] = i;
	}
	int f = v[n];
	printf("%d",f);
	/*

	
	for (int i = n-1; i >= 0; i--)
		f = f*x + v[i];
		*/
	return f;
}

// プログラムの実行: Ctrl + F5 または [デバッグ] > [デバッグなしで開始] メニュー
// プログラムのデバッグ: F5 または [デバッグ] > [デバッグの開始] メニュー

// 作業を開始するためのヒント: 
//    1. ソリューション エクスプローラー ウィンドウを使用してファイルを追加/管理します 
//   2. チーム エクスプローラー ウィンドウを使用してソース管理に接続します
//   3. 出力ウィンドウを使用して、ビルド出力とその他のメッセージを表示します
//   4. エラー一覧ウィンドウを使用してエラーを表示します
//   5. [プロジェクト] > [新しい項目の追加] と移動して新しいコード ファイルを作成するか、[プロジェクト] > [既存の項目の追加] と移動して既存のコード ファイルをプロジェクトに追加します
//   6. 後ほどこのプロジェクトを再び開く場合、[ファイル] > [開く] > [プロジェクト] と移動して .sln ファイルを選択します
