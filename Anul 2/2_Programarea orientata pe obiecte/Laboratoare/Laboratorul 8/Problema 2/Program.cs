﻿using Problema_2;
Punct PunctulMeu = new Punct();
Punct PunctulTau= new Punct();
PunctulMeu.Citire();
PunctulTau.Citire();
Console.Clear();
Console.WriteLine($"Suma = {(PunctulMeu+PunctulTau).ToString()} ");
Console.WriteLine($"Diferenta = {(PunctulMeu - PunctulTau).ToString()} ");
Console.WriteLine($"Produsul = {(PunctulMeu * PunctulTau).ToString()} ");
Console.WriteLine($"Catul = {(PunctulMeu / PunctulTau).ToString()} ");