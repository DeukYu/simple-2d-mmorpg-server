﻿#include "pch.h"
#include <thread>

void HelloThread()
{
    cout << "Hello Thread" << endl;
}

void HelloThread_2(int32 num)
{
    cout << num << endl;
}

int main()
{   
    vector<thread> v;

    for (int32 i = 0; i < 10; ++i) {
        v.emplace_back(thread(HelloThread_2, i));
    }

    for (int32 i = 0; i < 10; ++i)
    {
        if (v[i].joinable())
            v[i].join();
    }

    cout << "Hello Main" << endl;
}