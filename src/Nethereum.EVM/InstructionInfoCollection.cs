﻿using System.Collections.Generic;

namespace Loom.Nethereum.EVM
{
    public class InstructionInfoCollection
    {

        public static Dictionary<Instruction, InstructionInfo> Instructions = new Dictionary<Instruction, InstructionInfo>()
        { //                                                                  Add, Args, Ret, SideEffects, GasPriceTier
            { Instruction.STOP,        new InstructionInfo( "STOP",           0, 0, 0, true, GasPriceTier.ZeroTier ) } ,
            { Instruction.ADD,         new InstructionInfo( "ADD",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SUB,         new InstructionInfo( "SUB",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.MUL,         new InstructionInfo( "MUL",            0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.DIV,         new InstructionInfo( "DIV",            0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.SDIV,        new InstructionInfo( "SDIV",           0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.MOD,         new InstructionInfo( "MOD",            0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.SMOD,        new InstructionInfo( "SMOD",           0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.EXP,         new InstructionInfo( "EXP",            0, 2, 1, false, GasPriceTier.SpecialTier ) },
            { Instruction.NOT,         new InstructionInfo( "NOT",            0, 1, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.LT,          new InstructionInfo( "LT",             0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.GT,          new InstructionInfo( "GT",             0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SLT,         new InstructionInfo( "SLT",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SGT,         new InstructionInfo( "SGT",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.EQ,          new InstructionInfo( "EQ",             0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.ISZERO,      new InstructionInfo( "ISZERO",         0, 1, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.AND,         new InstructionInfo( "AND",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.OR,          new InstructionInfo( "OR",             0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.XOR,         new InstructionInfo( "XOR",            0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.BYTE,        new InstructionInfo( "BYTE",           0, 2, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.ADDMOD,      new InstructionInfo( "ADDMOD",         0, 3, 1, false, GasPriceTier.MidTier ) },
            { Instruction.MULMOD,      new InstructionInfo( "MULMOD",         0, 3, 1, false, GasPriceTier.MidTier ) },
            { Instruction.SIGNEXTEND,  new InstructionInfo( "SIGNEXTEND",     0, 2, 1, false, GasPriceTier.LowTier ) },
            { Instruction.SHA3,        new InstructionInfo( "SHA3",           0, 2, 1, false, GasPriceTier.SpecialTier ) },
            { Instruction.ADDRESS,     new InstructionInfo( "ADDRESS",        0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.BALANCE,     new InstructionInfo( "BALANCE",        0, 1, 1, false, GasPriceTier.ExtTier ) },
            { Instruction.ORIGIN,      new InstructionInfo( "ORIGIN",         0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.CALLER,      new InstructionInfo( "CALLER",         0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.CALLVALUE,   new InstructionInfo( "CALLVALUE",      0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.CALLDATALOAD,new InstructionInfo( "CALLDATALOAD",   0, 1, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.CALLDATASIZE,new InstructionInfo( "CALLDATASIZE",   0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.CALLDATACOPY,new InstructionInfo( "CALLDATACOPY",   0, 3, 0, true, GasPriceTier.VeryLowTier ) },
            { Instruction.CODESIZE,    new InstructionInfo( "CODESIZE",       0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.CODECOPY,    new InstructionInfo( "CODECOPY",       0, 3, 0, true, GasPriceTier.VeryLowTier ) },
            { Instruction.GASPRICE,    new InstructionInfo( "GASPRICE",       0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.EXTCODESIZE, new InstructionInfo( "EXTCODESIZE",    0, 1, 1, false, GasPriceTier.ExtTier ) },
            { Instruction.EXTCODECOPY, new InstructionInfo( "EXTCODECOPY",    0, 4, 0, true, GasPriceTier.ExtTier ) },
            { Instruction.BLOCKHASH,   new InstructionInfo( "BLOCKHASH",      0, 1, 1, false, GasPriceTier.ExtTier ) },
            { Instruction.COINBASE,    new InstructionInfo( "COINBASE",       0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.TIMESTAMP,   new InstructionInfo( "TIMESTAMP",      0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.NUMBER,      new InstructionInfo( "NUMBER",         0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.DIFFICULTY,  new InstructionInfo( "DIFFICULTY",     0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.GASLIMIT,    new InstructionInfo( "GASLIMIT",       0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.POP,         new InstructionInfo( "POP",            0, 1, 0, false, GasPriceTier.BaseTier ) },
            { Instruction.MLOAD,       new InstructionInfo( "MLOAD",          0, 1, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.MSTORE,      new InstructionInfo( "MSTORE",         0, 2, 0, true, GasPriceTier.VeryLowTier ) },
            { Instruction.MSTORE8,     new InstructionInfo( "MSTORE8",        0, 2, 0, true, GasPriceTier.VeryLowTier ) },
            { Instruction.SLOAD,       new InstructionInfo( "SLOAD",          0, 1, 1, false, GasPriceTier.SpecialTier ) },
            { Instruction.SSTORE,      new InstructionInfo( "SSTORE",         0, 2, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.JUMP,        new InstructionInfo( "JUMP",           0, 1, 0, true, GasPriceTier.MidTier ) },
            { Instruction.JUMPI,       new InstructionInfo( "JUMPI",          0, 2, 0, true, GasPriceTier.HighTier ) },
            { Instruction.PC,          new InstructionInfo( "PC",             0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.MSIZE,       new InstructionInfo( "MSIZE",          0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.GAS,         new InstructionInfo( "GAS",            0, 0, 1, false, GasPriceTier.BaseTier ) },
            { Instruction.JUMPDEST,    new InstructionInfo( "JUMPDEST",       0, 0, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.PUSH1,       new InstructionInfo( "PUSH1",          1, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH2,       new InstructionInfo( "PUSH2",          2, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH3,       new InstructionInfo( "PUSH3",          3, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH4,       new InstructionInfo( "PUSH4",          4, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH5,       new InstructionInfo( "PUSH5",          5, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH6,       new InstructionInfo( "PUSH6",          6, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH7,       new InstructionInfo( "PUSH7",          7, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH8,       new InstructionInfo( "PUSH8",          8, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH9,       new InstructionInfo( "PUSH9",          9, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH10,      new InstructionInfo( "PUSH10",         10, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH11,      new InstructionInfo( "PUSH11",         11, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH12,      new InstructionInfo( "PUSH12",         12, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH13,      new InstructionInfo( "PUSH13",         13, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH14,      new InstructionInfo( "PUSH14",         14, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH15,      new InstructionInfo( "PUSH15",         15, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH16,      new InstructionInfo( "PUSH16",         16, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH17,      new InstructionInfo( "PUSH17",         17, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH18,      new InstructionInfo( "PUSH18",         18, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH19,      new InstructionInfo( "PUSH19",         19, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH20,      new InstructionInfo( "PUSH20",         20, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH21,      new InstructionInfo( "PUSH21",         21, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH22,      new InstructionInfo( "PUSH22",         22, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH23,      new InstructionInfo( "PUSH23",         23, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH24,      new InstructionInfo( "PUSH24",         24, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH25,      new InstructionInfo( "PUSH25",         25, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH26,      new InstructionInfo( "PUSH26",         26, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH27,      new InstructionInfo( "PUSH27",         27, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH28,      new InstructionInfo( "PUSH28",         28, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH29,      new InstructionInfo( "PUSH29",         29, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH30,      new InstructionInfo( "PUSH30",         30, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH31,      new InstructionInfo( "PUSH31",         31, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.PUSH32,      new InstructionInfo( "PUSH32",         32, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP1,        new InstructionInfo( "DUP1",           0, 1, 2, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP2,        new InstructionInfo( "DUP2",           0, 2, 3, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP3,        new InstructionInfo( "DUP3",           0, 3, 4, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP4,        new InstructionInfo( "DUP4",           0, 4, 5, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP5,        new InstructionInfo( "DUP5",           0, 5, 6, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP6,        new InstructionInfo( "DUP6",           0, 6, 7, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP7,        new InstructionInfo( "DUP7",           0, 7, 8, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP8,        new InstructionInfo( "DUP8",           0, 8, 9, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP9,        new InstructionInfo( "DUP9",           0, 9, 10, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP10,       new InstructionInfo( "DUP10",          0, 10, 11, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP11,       new InstructionInfo( "DUP11",          0, 11, 12, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP12,       new InstructionInfo( "DUP12",          0, 12, 13, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP13,       new InstructionInfo( "DUP13",          0, 13, 14, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP14,       new InstructionInfo( "DUP14",          0, 14, 15, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP15,       new InstructionInfo( "DUP15",          0, 15, 16, false, GasPriceTier.VeryLowTier ) },
            { Instruction.DUP16,       new InstructionInfo( "DUP16",          0, 16, 17, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP1,       new InstructionInfo( "SWAP1",          0, 2, 2, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP2,       new InstructionInfo( "SWAP2",          0, 3, 3, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP3,       new InstructionInfo( "SWAP3",          0, 4, 4, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP4,       new InstructionInfo( "SWAP4",          0, 5, 5, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP5,       new InstructionInfo( "SWAP5",          0, 6, 6, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP6,       new InstructionInfo( "SWAP6",          0, 7, 7, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP7,       new InstructionInfo( "SWAP7",          0, 8, 8, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP8,       new InstructionInfo( "SWAP8",          0, 9, 9, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP9,       new InstructionInfo( "SWAP9",          0, 10, 10, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP10,      new InstructionInfo( "SWAP10",         0, 11, 11, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP11,      new InstructionInfo( "SWAP11",         0, 12, 12, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP12,      new InstructionInfo( "SWAP12",         0, 13, 13, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP13,      new InstructionInfo( "SWAP13",         0, 14, 14, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP14,      new InstructionInfo( "SWAP14",         0, 15, 15, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP15,      new InstructionInfo( "SWAP15",         0, 16, 16, false, GasPriceTier.VeryLowTier ) },
            { Instruction.SWAP16,      new InstructionInfo( "SWAP16",         0, 17, 17, false, GasPriceTier.VeryLowTier ) },
            { Instruction.LOG0,        new InstructionInfo( "LOG0",           0, 2, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.LOG1,        new InstructionInfo( "LOG1",           0, 3, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.LOG2,        new InstructionInfo( "LOG2",           0, 4, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.LOG3,        new InstructionInfo( "LOG3",           0, 5, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.LOG4,        new InstructionInfo( "LOG4",           0, 6, 0, true, GasPriceTier.SpecialTier ) },
            { Instruction.CREATE,      new InstructionInfo( "CREATE",         0, 3, 1, true, GasPriceTier.SpecialTier ) },
            { Instruction.CALL,        new InstructionInfo( "CALL",           0, 7, 1, true, GasPriceTier.SpecialTier ) },
            { Instruction.CALLCODE,    new InstructionInfo( "CALLCODE",       0, 7, 1, true, GasPriceTier.SpecialTier ) },
            { Instruction.RETURN,      new InstructionInfo( "RETURN",         0, 2, 0, true, GasPriceTier.ZeroTier ) },
            { Instruction.DELEGATECALL,new InstructionInfo( "DELEGATECALL",   0, 6, 1, true, GasPriceTier.SpecialTier ) },
            { Instruction.SUICIDE,     new InstructionInfo( "SUICIDE",        0, 1, 0, true, GasPriceTier.ZeroTier ) },

            // these are generated by the interpreter - should never be in user code
            { Instruction.PUSHC,       new InstructionInfo( "PUSHC",          2, 0, 1, false, GasPriceTier.VeryLowTier ) },
            { Instruction.JUMPV,       new InstructionInfo( "JUMPV",          0, 1, 0, true, GasPriceTier.MidTier ) },
            { Instruction.JUMPVI,      new InstructionInfo( "JUMPVI",         0, 1, 0, true, GasPriceTier.HighTier ) }
           // { Instruction.STOP,        new InstructionInfo( "BAD",            0, 0, 0, true, GasPriceTier.ZeroTier ) },
        };
    }
}