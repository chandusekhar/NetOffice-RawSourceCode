﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSHTMLApi
{
	 /// <summary>
	 /// SupportByVersion MSHTML 4
	 /// </summary>
	[SupportByVersion("MSHTML", 4)]
	[StructLayout(LayoutKind.Sequential, Pack=4), Guid("00000000-0000-0000-0000-000000000000")]
	[EntityType(EntityType.IsStruct)]
	public struct wireHBITMAP
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		[SupportByVersion("MSHTML", 4)]
		public Int32 fContext;

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		[SupportByVersion("MSHTML", 4)]
		[MarshalAs(UnmanagedType.Interface)]
		public object u;
	}
}