﻿using BarlangokCLI;
using System.Text;

const string eleresiUt = "C:\\Users\\juhaszz\\source\\repos\\CSHARP241211\\BarlangokCLI\\src\\barlangok.txt";

List<Barlang> barlangok = [];

using StreamReader sr = new(eleresiUt, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: Barlangok száma: {barlangok.Count}");