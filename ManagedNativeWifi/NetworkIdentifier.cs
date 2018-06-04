﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedNativeWifi
{
	/// <summary>
	/// Identifier of wireless LAN
	/// </summary>
	/// <remarks>This class is immutable.</remarks>
	public class NetworkIdentifier
	{
		private readonly byte[] _rawBytes;
		private readonly string _rawString;

		/// <summary>
		/// Constructor
		/// </summary>
		public NetworkIdentifier(byte[] rawBytes, string rawString)
		{
			this._rawBytes = new byte[32];
			rawBytes.CopyTo(_rawBytes,0);
            this._rawString = rawString;
		}

		/// <summary>
		/// Returns the identifier in byte array.
		/// </summary>
		/// <returns>Identifier in byte array</returns>
		public byte[] ToBytes() => _rawBytes?.ToArray();

		public byte[] GetBytes() => _rawBytes;

		/// <summary>
		/// Returns the identifier in UTF-8 string.
		/// </summary>
		/// <returns>Identifier in UTF-8 string</returns>
		public override string ToString() => _rawString;
	}
}