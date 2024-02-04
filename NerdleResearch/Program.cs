﻿
using Solver;
using Validation;

var answers = Generation.possibleSolutions
    .Where(NerdleValidator.IsValidEquation)
    .ToList();

var solver = new NerdleSolver(answers);

//while (true)
//{
//    Console.WriteLine("What's your guess and result?!");
//    var guess = Console.ReadLine();
//    solver.DigestGuess(guess[..8], guess[8..16]);
//}

solver.DigestGuess("8*5-4=36", "BBBPPGBB");
