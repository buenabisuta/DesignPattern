﻿using System;

namespace DesinPattern.Bridge
{
    public abstract class DisplayImpl
    {
        public abstract void RawOpen();
        public abstract void RawPrint();
        public abstract void RawClose();
    }
}