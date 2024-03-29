// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

extern alias shims;
using System;
using shims::System.Numerics;
using Xunit;

namespace System.Numerics.Tests
{
    public static class BitOperationsTests
    {
        [Theory]
        [InlineData(0b0, false)]
        [InlineData(0b01, true)]
        [InlineData(0b10, true)]
        [InlineData(0b11, false)]
        [InlineData(0b100, true)]
        [InlineData(0b101, false)]
        [InlineData(0b110, false)]
        [InlineData(0b111, false)]
        [InlineData(0b1000, true)]
        [InlineData(0b1001, false)]
        [InlineData(0b1010, false)]
        [InlineData(0b1011, false)]
        [InlineData(0b1100, false)]
        [InlineData(0b1101, false)]
        [InlineData(0b1110, false)]
        [InlineData(0b1111, false)]
        [InlineData(0b10000, true)]
        [InlineData(0b11111, false)]
        [InlineData(0b100000, true)]
        [InlineData(0b100001, false)]
        public static void BitOps_IsPow2_int(int n, bool expected)
        {
            bool actual = BitOperations.IsPow2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0u, false)]
        [InlineData(0b01u, true)]
        [InlineData(0b10u, true)]
        [InlineData(0b11u, false)]
        [InlineData(0b100u, true)]
        [InlineData(0b101u, false)]
        [InlineData(0b110u, false)]
        [InlineData(0b111u, false)]
        [InlineData(0b1000u, true)]
        [InlineData(0b1001u, false)]
        [InlineData(0b1010u, false)]
        [InlineData(0b1011u, false)]
        [InlineData(0b1100u, false)]
        [InlineData(0b1101u, false)]
        [InlineData(0b1110u, false)]
        [InlineData(0b1111u, false)]
        [InlineData(0b10000u, true)]
        [InlineData(0b11111u, false)]
        [InlineData(0b100000u, true)]
        [InlineData(0b100001u, false)]
        public static void BitOps_IsPow2_uint(uint n, bool expected)
        {
            bool actual = BitOperations.IsPow2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0L, false)]
        [InlineData(0b01L, true)]
        [InlineData(0b10L, true)]
        [InlineData(0b11L, false)]
        [InlineData(0b100L, true)]
        [InlineData(0b101L, false)]
        [InlineData(0b110L, false)]
        [InlineData(0b111L, false)]
        [InlineData(0b1000L, true)]
        [InlineData(0b1001L, false)]
        [InlineData(0b1010L, false)]
        [InlineData(0b1011L, false)]
        [InlineData(0b1100L, false)]
        [InlineData(0b1101L, false)]
        [InlineData(0b1110L, false)]
        [InlineData(0b1111L, false)]
        [InlineData(0b10000L, true)]
        [InlineData(0b11111L, false)]
        [InlineData(0b100000L, true)]
        [InlineData(0b100001L, false)]
        public static void BitOps_IsPow2_long(long n, bool expected)
        {
            bool actual = BitOperations.IsPow2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0ul, false)]
        [InlineData(0b01ul, true)]
        [InlineData(0b10ul, true)]
        [InlineData(0b11ul, false)]
        [InlineData(0b100ul, true)]
        [InlineData(0b101ul, false)]
        [InlineData(0b110ul, false)]
        [InlineData(0b111ul, false)]
        [InlineData(0b1000ul, true)]
        [InlineData(0b1001ul, false)]
        [InlineData(0b1010ul, false)]
        [InlineData(0b1011ul, false)]
        [InlineData(0b1100ul, false)]
        [InlineData(0b1101ul, false)]
        [InlineData(0b1110ul, false)]
        [InlineData(0b1111ul, false)]
        [InlineData(0b10000ul, true)]
        [InlineData(0b11111ul, false)]
        [InlineData(0b100000ul, true)]
        [InlineData(0b100001ul, false)]
        public static void BitOps_IsPow2_ulong(ulong n, bool expected)
        {
            bool actual = BitOperations.IsPow2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0, false)]
        [InlineData(0b01, true)]
        [InlineData(0b10, true)]
        [InlineData(0b11, false)]
        [InlineData(0b100, true)]
        [InlineData(0b101, false)]
        [InlineData(0b110, false)]
        [InlineData(0b111, false)]
        [InlineData(0b1000, true)]
        [InlineData(0b1001, false)]
        [InlineData(0b1010, false)]
        [InlineData(0b1011, false)]
        [InlineData(0b1100, false)]
        [InlineData(0b1101, false)]
        [InlineData(0b1110, false)]
        [InlineData(0b1111, false)]
        [InlineData(0b10000, true)]
        [InlineData(0b11111, false)]
        [InlineData(0b100000, true)]
        [InlineData(0b100001, false)]
        public static void BitOps_IsPow2_nint(int n, bool expected)
        {
            bool actual = BitOperations.IsPow2((nint)n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0u, false)]
        [InlineData(0b01u, true)]
        [InlineData(0b10u, true)]
        [InlineData(0b11u, false)]
        [InlineData(0b100u, true)]
        [InlineData(0b101u, false)]
        [InlineData(0b110u, false)]
        [InlineData(0b111u, false)]
        [InlineData(0b1000u, true)]
        [InlineData(0b1001u, false)]
        [InlineData(0b1010u, false)]
        [InlineData(0b1011u, false)]
        [InlineData(0b1100u, false)]
        [InlineData(0b1101u, false)]
        [InlineData(0b1110u, false)]
        [InlineData(0b1111u, false)]
        [InlineData(0b10000u, true)]
        [InlineData(0b11111u, false)]
        [InlineData(0b100000u, true)]
        [InlineData(0b100001u, false)]
        public static void BitOps_IsPow2_nuint(uint n, bool expected)
        {
            bool actual = BitOperations.IsPow2((nuint)n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0u, 0u)]
        [InlineData(0b01, 1u)]
        [InlineData(0b10u, 2u)]
        [InlineData(0b11u, 4u)]
        [InlineData(0b100u, 4u)]
        [InlineData(0b101u, 8u)]
        [InlineData(0b110u, 8u)]
        [InlineData(0b111u, 8u)]
        [InlineData(0b1000u, 8u)]
        [InlineData(0b1001u, 16u)]
        [InlineData(0b1010u, 16u)]
        [InlineData(0b1011u, 16u)]
        [InlineData(0b1100u, 16u)]
        [InlineData(0b1101u, 16u)]
        [InlineData(0b1110u, 16u)]
        [InlineData(0b1111u, 16u)]
        [InlineData(0b10000u, 16u)]
        [InlineData(0b11111u, 32u)]
        [InlineData(0b100000u, 32u)]
        [InlineData(0b100001u, 64u)]
        [InlineData(uint.MaxValue, 0u)]
        public static void BitOps_RoundUpToPowerOf2_uint(uint n, uint expected)
        {
            uint actual = BitOperations.RoundUpToPowerOf2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0ul, 0ul)]
        [InlineData(0b01, 1ul)]
        [InlineData(0b10ul, 2ul)]
        [InlineData(0b11ul, 4ul)]
        [InlineData(0b100ul, 4ul)]
        [InlineData(0b101ul, 8ul)]
        [InlineData(0b110ul, 8ul)]
        [InlineData(0b111ul, 8ul)]
        [InlineData(0b1000ul, 8ul)]
        [InlineData(0b1001ul, 16ul)]
        [InlineData(0b1010ul, 16ul)]
        [InlineData(0b1011ul, 16ul)]
        [InlineData(0b1100ul, 16ul)]
        [InlineData(0b1101ul, 16ul)]
        [InlineData(0b1110ul, 16ul)]
        [InlineData(0b1111ul, 16ul)]
        [InlineData(0b10000ul, 16ul)]
        [InlineData(0b11111ul, 32ul)]
        [InlineData(0b100000ul, 32ul)]
        [InlineData(0b100001ul, 64ul)]
        [InlineData(ulong.MaxValue, 0ul)]
        public static void BitOps_RoundUpToPowerOf2_ulong(ulong n, ulong expected)
        {
            ulong actual = BitOperations.RoundUpToPowerOf2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b0u, 0u)]
        [InlineData(0b01, 1u)]
        [InlineData(0b10u, 2u)]
        [InlineData(0b11u, 4u)]
        [InlineData(0b100u, 4u)]
        [InlineData(0b101u, 8u)]
        [InlineData(0b110u, 8u)]
        [InlineData(0b111u, 8u)]
        [InlineData(0b1000u, 8u)]
        [InlineData(0b1001u, 16u)]
        [InlineData(0b1010u, 16u)]
        [InlineData(0b1011u, 16u)]
        [InlineData(0b1100u, 16u)]
        [InlineData(0b1101u, 16u)]
        [InlineData(0b1110u, 16u)]
        [InlineData(0b1111u, 16u)]
        [InlineData(0b10000u, 16u)]
        [InlineData(0b11111u, 32u)]
        [InlineData(0b100000u, 32u)]
        [InlineData(0b100001u, 64u)]
        [InlineData(uint.MaxValue, 0u)]
        public static void BitOps_RoundUpToPowerOf2_nuint(uint n, uint expected)
        {
            nuint actual = BitOperations.RoundUpToPowerOf2((nuint)n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0u, 32)]
        [InlineData(0b1u, 31)]
        [InlineData(0b10u, 30)]
        [InlineData(0b100u, 29)]
        [InlineData(0b1000u, 28)]
        [InlineData(0b10000u, 27)]
        [InlineData(0b100000u, 26)]
        [InlineData(0b1000000u, 25)]
        [InlineData(byte.MaxValue << 17, 32 - 8 - 17)]
        [InlineData(byte.MaxValue << 9, 32 - 8 - 9)]
        [InlineData(ushort.MaxValue << 11, 32 - 16 - 11)]
        [InlineData(ushort.MaxValue << 2, 32 - 16 - 2)]
        [InlineData(5 << 7, 32 - 3 - 7)]
        [InlineData(uint.MaxValue, 0)]
        public static void BitOps_LeadingZeroCount_uint(uint n, int expected)
        {
            int actual = BitOperations.LeadingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0ul, 64)]
        [InlineData(0b1ul, 63)]
        [InlineData(0b10ul, 62)]
        [InlineData(0b100ul, 61)]
        [InlineData(0b1000ul, 60)]
        [InlineData(0b10000ul, 59)]
        [InlineData(0b100000ul, 58)]
        [InlineData(0b1000000ul, 57)]
        [InlineData((ulong)byte.MaxValue << 41, 64 - 8 - 41)]
        [InlineData((ulong)byte.MaxValue << 53, 64 - 8 - 53)]
        [InlineData((ulong)ushort.MaxValue << 31, 64 - 16 - 31)]
        [InlineData((ulong)ushort.MaxValue << 15, 64 - 16 - 15)]
        [InlineData(ulong.MaxValue >> 5, 5)]
        [InlineData(1ul << 63, 0)]
        [InlineData(1ul << 62, 1)]
        [InlineData(ulong.MaxValue, 0)]
        public static void BitOps_LeadingZeroCount_ulong(ulong n, int expected)
        {
            int actual = BitOperations.LeadingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0u, 32)]
        [InlineData(0b1u, 0)]
        [InlineData(0b10u, 1)]
        [InlineData(0b100u, 2)]
        [InlineData(0b1000u, 3)]
        [InlineData(0b10000u, 4)]
        [InlineData(0b100000u, 5)]
        [InlineData(0b1000000u, 6)]
        [InlineData((uint)byte.MaxValue << 24, 24)]
        [InlineData((uint)byte.MaxValue << 22, 22)]
        [InlineData((uint)ushort.MaxValue << 16, 16)]
        [InlineData((uint)ushort.MaxValue << 19, 19)]
        [InlineData(uint.MaxValue << 5, 5)]
        [InlineData(3u << 27, 27)]
        [InlineData(uint.MaxValue, 0)]
        public static void BitOps_TrailingZeroCount_uint(uint n, int expected)
        {
            int actual = BitOperations.TrailingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 32)]
        [InlineData(0b1, 0)]
        [InlineData(0b10, 1)]
        [InlineData(0b100, 2)]
        [InlineData(0b1000, 3)]
        [InlineData(0b10000, 4)]
        [InlineData(0b100000, 5)]
        [InlineData(0b1000000, 6)]
        [InlineData(byte.MaxValue << 24, 24)]
        [InlineData(byte.MaxValue << 22, 22)]
        [InlineData(ushort.MaxValue << 16, 16)]
        [InlineData(ushort.MaxValue << 19, 19)]
        [InlineData(int.MaxValue << 5, 5)]
        [InlineData(3 << 27, 27)]
        [InlineData(int.MaxValue, 0)]
        public static void BitOps_TrailingZeroCount_int(int n, int expected)
        {
            int actual = BitOperations.TrailingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0ul, 64)]
        [InlineData(0b1ul, 0)]
        [InlineData(0b10ul, 1)]
        [InlineData(0b100ul, 2)]
        [InlineData(0b1000ul, 3)]
        [InlineData(0b10000ul, 4)]
        [InlineData(0b100000ul, 5)]
        [InlineData(0b1000000ul, 6)]
        [InlineData((ulong)byte.MaxValue << 40, 40)]
        [InlineData((ulong)byte.MaxValue << 57, 57)]
        [InlineData((ulong)ushort.MaxValue << 31, 31)]
        [InlineData((ulong)ushort.MaxValue << 15, 15)]
        [InlineData(ulong.MaxValue << 5, 5)]
        [InlineData(3ul << 59, 59)]
        [InlineData(5ul << 63, 63)]
        [InlineData(ulong.MaxValue, 0)]
        public static void BitOps_TrailingZeroCount_ulong(ulong n, int expected)
        {
            int actual = BitOperations.TrailingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0L, 64)]
        [InlineData(0b1L, 0)]
        [InlineData(0b10L, 1)]
        [InlineData(0b100L, 2)]
        [InlineData(0b1000L, 3)]
        [InlineData(0b10000L, 4)]
        [InlineData(0b100000L, 5)]
        [InlineData(0b1000000L, 6)]
        [InlineData((long)byte.MaxValue << 40, 40)]
        [InlineData((long)byte.MaxValue << 57, 57)]
        [InlineData((long)ushort.MaxValue << 31, 31)]
        [InlineData((long)ushort.MaxValue << 15, 15)]
        [InlineData(long.MaxValue << 5, 5)]
        [InlineData(3L << 59, 59)]
        [InlineData(5L << 63, 63)]
        [InlineData(long.MaxValue, 0)]
        public static void BitOps_TrailingZeroCount_long(long n, int expected)
        {
            int actual = BitOperations.TrailingZeroCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2 - 1)]
        [InlineData(4, 2)]
        [InlineData(5, 3 - 1)]
        [InlineData(6, 3 - 1)]
        [InlineData(7, 3 - 1)]
        [InlineData(8, 3)]
        [InlineData(9, 4 - 1)]
        [InlineData(byte.MaxValue, 8 - 1)]
        [InlineData(ushort.MaxValue, 16 - 1)]
        [InlineData(uint.MaxValue, 32 - 1)]
        public static void BitOps_Log2_uint(uint n, int expected)
        {
            int actual = BitOperations.Log2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2 - 1)]
        [InlineData(4, 2)]
        [InlineData(5, 3 - 1)]
        [InlineData(6, 3 - 1)]
        [InlineData(7, 3 - 1)]
        [InlineData(8, 3)]
        [InlineData(9, 4 - 1)]
        [InlineData(byte.MaxValue, 8 - 1)]
        [InlineData(ushort.MaxValue, 16 - 1)]
        [InlineData(uint.MaxValue, 32 - 1)]
        [InlineData(ulong.MaxValue, 64 - 1)]
        public static void BitOps_Log2_ulong(ulong n, int expected)
        {
            int actual = BitOperations.Log2(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b001, 1)]
        [InlineData(0b010, 1)]
        [InlineData(0b011, 2)]
        [InlineData(0b100, 1)]
        [InlineData(0b101, 2)]
        [InlineData(0b110, 2)]
        [InlineData(0b111, 3)]
        [InlineData(0b1101, 3)]
        [InlineData(0b1111, 4)]
        [InlineData(0b10111, 4)]
        [InlineData(0b11111, 5)]
        [InlineData(0b110111, 5)]
        [InlineData(0b111111, 6)]
        [InlineData(0b1111110, 6)]
        [InlineData(byte.MinValue, 0)] // 0
        [InlineData(byte.MaxValue, 8)] // 255
        [InlineData(unchecked((uint)sbyte.MinValue), 25)] // 4294967168
        [InlineData(sbyte.MaxValue, 7)] // 127
        [InlineData(ushort.MaxValue >> 3, 16 - 3)] // 8191
        [InlineData(ushort.MaxValue, 16)] // 65535
        [InlineData(unchecked((uint)short.MinValue), 32 - 15)] // 4294934528
        [InlineData(short.MaxValue, 15)] // 32767
        [InlineData(unchecked((uint)int.MinValue), 1)] // 2147483648
        [InlineData(unchecked((uint)int.MaxValue), 31)] // 4294967168
        [InlineData(uint.MaxValue >> 5, 32 - 5)] // 134217727
        [InlineData(uint.MaxValue << 11, 32 - 11)] // 4294965248
        [InlineData(uint.MaxValue, 32)] // 4294967295
        public static void BitOps_PopCount_uint(uint n, int expected)
        {
            int actual = BitOperations.PopCount(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0b001, 1)]
        [InlineData(0b010, 1)]
        [InlineData(0b011, 2)]
        [InlineData(0b100, 1)]
        [InlineData(0b101, 2)]
        [InlineData(0b110, 2)]
        [InlineData(0b111, 3)]
        [InlineData(0b1101, 3)]
        [InlineData(0b1111, 4)]
        [InlineData(0b10111, 4)]
        [InlineData(0b11111, 5)]
        [InlineData(0b110111, 5)]
        [InlineData(0b111111, 6)]
        [InlineData(0b1111110, 6)]
        [InlineData(0b1111111, 7)]
        [InlineData(byte.MinValue, 0)] // 0
        [InlineData(byte.MaxValue, 8)] // 255
        [InlineData(unchecked((ulong)sbyte.MinValue), 57)] // 18446744073709551488
        [InlineData(sbyte.MaxValue, 7)] // 127
        [InlineData(ushort.MaxValue, 16)] // 65535
        [InlineData(unchecked((ulong)short.MinValue), 49)] // 18446744073709518848
        [InlineData(short.MaxValue, 15)] // 32767
        [InlineData(unchecked((ulong)int.MinValue), 64 - 31)] // 18446744071562067968
        [InlineData(int.MaxValue, 31)] // 2147483647
        [InlineData(ulong.MaxValue >> 9, 64 - 9)] // 36028797018963967
        [InlineData(ulong.MaxValue << 11, 64 - 11)] // 18446744073709549568
        [InlineData(ulong.MaxValue, 64)]
        public static void BitOps_PopCount_ulong(ulong n, int expected)
        {
            int actual = BitOperations.PopCount(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void BitOps_PopCount_Constant()
        {
            // PopCount returns constant for constant input

            Assert.Equal(0, BitOperations.PopCount(0U));
            Assert.Equal(1, BitOperations.PopCount(1U));
            Assert.Equal(1, BitOperations.PopCount(2U));
            Assert.Equal(6, BitOperations.PopCount(1111U));
            Assert.Equal(29, BitOperations.PopCount(unchecked((uint)-101)));
            Assert.Equal(31, BitOperations.PopCount(4294967294U));
            Assert.Equal(32, BitOperations.PopCount(4294967295U));

            Assert.Equal(0, BitOperations.PopCount(0UL));
            Assert.Equal(1, BitOperations.PopCount(1UL));
            Assert.Equal(1, BitOperations.PopCount(2UL));
            Assert.Equal(6, BitOperations.PopCount(1111UL));
            Assert.Equal(31, BitOperations.PopCount(4294967294UL));
            Assert.Equal(32, BitOperations.PopCount(4294967295UL));
            Assert.Equal(61, BitOperations.PopCount(unchecked((ulong)-101)));
            Assert.Equal(63, BitOperations.PopCount(18446744073709551614UL));
            Assert.Equal(64, BitOperations.PopCount(18446744073709551615UL));
        }

        [Theory]
        [InlineData(0b00000000_00000000_00000000_00000001u, int.MaxValue, 0b10000000_00000000_00000000_00000000u)] // % 32 = 31
        [InlineData(0b01000000_00000001_00000000_00000001u, 3, 0b00000000_00001000_00000000_00001010u)]
        [InlineData(0b01000000_00000001_00000000_00000001u, 2, 0b00000000_00000100_00000000_00000101u)]
        [InlineData(0b01010101_01010101_01010101_01010101u, 1, 0b10101010_10101010_10101010_10101010u)]
        [InlineData(0b01010101_11111111_01010101_01010101u, 0, 0b01010101_11111111_01010101_01010101u)]
        [InlineData(0b00000000_00000000_00000000_00000001u, -1, 0b10000000_00000000_00000000_00000000u)]
        [InlineData(0b00000000_00000000_00000000_00000001u, -2, 0b01000000_00000000_00000000_00000000u)]
        [InlineData(0b00000000_00000000_00000000_00000001u, -3, 0b00100000_00000000_00000000_00000000u)]
        [InlineData(0b01010101_11111111_01010101_01010101u, int.MinValue, 0b01010101_11111111_01010101_01010101u)] // % 32 = 0
        public static void BitOps_RotateLeft_uint(uint n, int offset, uint expected)
        {
            Assert.Equal(expected, BitOperations.RotateLeft(n, offset));
        }

        [Fact]
        public static void BitOps_RotateLeft_ulong()
        {
            ulong value = 0b01010101_01010101_01010101_01010101_01010101_01010101_01010101_01010101ul;
            Assert.Equal(0b10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010ul, BitOperations.RotateLeft(value, 1));
            Assert.Equal(0b01010101_01010101_01010101_01010101_01010101_01010101_01010101_01010101ul, BitOperations.RotateLeft(value, 2));
            Assert.Equal(0b10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010ul, BitOperations.RotateLeft(value, 3));
            Assert.Equal(value, BitOperations.RotateLeft(value, int.MinValue)); // % 64 = 0
            Assert.Equal(BitOperations.RotateLeft(value, 63), BitOperations.RotateLeft(value, int.MaxValue)); // % 64 = 63
        }

        [Theory]
        [InlineData(0b10000000_00000000_00000000_00000000u, int.MaxValue, 0b00000000_00000000_00000000_00000001u)] // % 32 = 31
        [InlineData(0b00000000_00001000_00000000_00001010u, 3, 0b01000000_00000001_00000000_00000001u)]
        [InlineData(0b00000000_00000100_00000000_00000101u, 2, 0b01000000_00000001_00000000_00000001u)]
        [InlineData(0b01010101_01010101_01010101_01010101u, 1, 0b10101010_10101010_10101010_10101010u)]
        [InlineData(0b01010101_11111111_01010101_01010101u, 0, 0b01010101_11111111_01010101_01010101u)]
        [InlineData(0b10000000_00000000_00000000_00000000u, -1, 0b00000000_00000000_00000000_00000001u)]
        [InlineData(0b00000000_00000000_00000000_00000001u, -2, 0b00000000_00000000_00000000_00000100u)]
        [InlineData(0b01000000_00000000_00000000_00000000u, -3, 0b00000000_00000000_00000000_00000010u)]
        [InlineData(0b01010101_11111111_01010101_01010101u, int.MinValue, 0b01010101_11111111_01010101_01010101u)] // % 32 = 0
        public static void BitOps_RotateRight_uint(uint n, int offset, uint expected)
        {
            Assert.Equal(expected, BitOperations.RotateRight(n, offset));
        }

        [Fact]
        public static void BitOps_RotateRight_ulong()
        {
            ulong value = 0b01010101_01010101_01010101_01010101_01010101_01010101_01010101_01010101ul;
            Assert.Equal(0b10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010ul, BitOperations.RotateRight(value, 1));
            Assert.Equal(0b01010101_01010101_01010101_01010101_01010101_01010101_01010101_01010101ul, BitOperations.RotateRight(value, 2));
            Assert.Equal(0b10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010ul, BitOperations.RotateRight(value, 3));
            Assert.Equal(value, BitOperations.RotateRight(value, int.MinValue)); // % 64 = 0
            Assert.Equal(BitOperations.RotateLeft(value, 63), BitOperations.RotateRight(value, int.MaxValue)); // % 64 = 63
        }
    }
}
