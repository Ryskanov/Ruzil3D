using System;

namespace Ruzil3D
{
	/// <summary>
	/// ����������� ������� ���� ����� � ������ ������ � ������ ������ � ������� ���� �����.
	/// </summary>
	public static class TypeConverter
	{
		private static long GetLong(byte[] buffer, int from, int step, int length)
		{
			var result = 0L;

			for (var i = 0; i < length; i++)
			{
				result = result * 256 + buffer[from];
				from += step;
			}

			return result;
		}

		private static long GetLong(byte[] buffer, int startIndex, int length)
		{
			if (startIndex >= 0 && buffer.Length - startIndex >= length)
			{
				return GetLong(buffer, startIndex + length - 1, -1, length);
			}

			if (startIndex < 0 && startIndex <= 1 - length)
			{
				return GetLong(buffer, startIndex + length - 1, 1, length);
			}

			throw new ArgumentOutOfRangeException();
		}

		/// <summary>
		/// ���������� 8-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>8-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static sbyte ToSByte(byte[] buffer, int startIndex)
		{
			return (sbyte)GetLong(buffer, startIndex, 1);
		}

		/// <summary>
		/// ���������� 16-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>16-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static short ToInt16(byte[] buffer, int startIndex)
		{
			return (short)GetLong(buffer, startIndex, 2);
		}

		/// <summary>
		/// ���������� 32-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>32-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static int ToInt32(byte[] buffer, int startIndex)
		{
			return (int)GetLong(buffer, startIndex, 4);
		}

		/// <summary>
		/// ���������� 64-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>64-������� ����� ����� �� ������, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static long ToInt64(byte[] buffer, int startIndex)
		{
			return GetLong(buffer, startIndex, 8);
		}

		/// <summary>
		/// ���������� 8-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>8-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static byte ToByte(byte[] buffer, int startIndex)
		{
			return (byte)GetLong(buffer, startIndex, 1);
		}

		/// <summary>
		/// ���������� 16-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>16-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static ushort ToUInt16(byte[] buffer, int startIndex)
		{
			return (ushort)GetLong(buffer, startIndex, 2);
		}

		/// <summary>
		/// ���������� 32-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>32-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static uint ToUInt32(byte[] buffer, int startIndex)
		{
			return (uint)GetLong(buffer, startIndex, 4);
		}

		/// <summary>
		/// ���������� 64-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.
		/// </summary>
		/// <param name="buffer">������ ������.</param>
		/// <param name="startIndex">������� ������ � <paramref name="buffer"/>. ���� <paramref name="startIndex"/> &lt; 0 �� ������� ���� ��������� � �������� �����������.</param>
		/// <returns>64-������� ����� ����� ��� �����, ��������������� �� ������� ������ � ��������� �������� � ������� ������.</returns>
		public static ulong ToUInt64(byte[] buffer, int startIndex)
		{
			return (ulong)GetLong(buffer, startIndex, 8);
		}
	}
}