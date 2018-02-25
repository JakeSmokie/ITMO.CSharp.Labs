﻿using ClassLib;

namespace CSLabs.Operations
{
    public interface IOperation
    {
        char OperatorChar { get; }

        bool Run(IProcessorStorage storage);
    }
}