﻿namespace Solver;

internal enum OccurenceType
{
    Unknown,
    Exactly,
    AtLeast,
    Dead
}

internal class CharacterInfo(char character, int count = -1, OccurenceType type = OccurenceType.Unknown)
{
    public char Character = character;
    public int Count = count;
    public OccurenceType Type = type;

    public override string ToString()
    {
        return Type switch
        {
            OccurenceType.AtLeast => $"{Character} | at least {Count}",
            OccurenceType.Exactly => $"{Character} | exactly {Count}",
            OccurenceType.Unknown => $"{Character} | ?",
            OccurenceType.Dead => $"{Character} | DEAD",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}