//
// System.Reflection.FieldInfo.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//
// TODO: Mucho left to implement.
//

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection {

	[Serializable]
	public abstract class FieldInfo : MemberInfo {

		public abstract FieldAttributes Attributes {get;}
		public abstract RuntimeFieldHandle FieldHandle {get;}

		public abstract Type FieldType { get; }

		public abstract object GetValue(object obj);

		public override MemberTypes MemberType {
			get { return MemberTypes.Field;}
		}

		public bool IsLiteral
		{
			get {return (Attributes & FieldAttributes.Literal) != 0;}
		} 

		public bool IsStatic
		{
			get {return (Attributes & FieldAttributes.Static) != 0;}
		} 

		public bool IsInitOnly
		{
			get {return (Attributes & FieldAttributes.InitOnly) != 0;}
		} 

		public abstract void SetValue (object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		[MonoTODO]
		public void SetValue( object obj, object value) {
		}
	}
}
