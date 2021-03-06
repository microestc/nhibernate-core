﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using NHibernate.Type;
using NUnit.Framework;

namespace NHibernate.Test.TypesTest
{
	using System.Threading.Tasks;
	/// <summary>
	/// The Unit Tests for the LocalDateTimeType.
	/// </summary>
	[TestFixture]
	public class LocalDateTimeTypeFixtureAsync : AbstractDateTimeTypeFixtureAsync
	{
		protected override string TypeName => "LocalDateTime";
		protected override AbstractDateTimeType Type => NHibernateUtil.LocalDateTime;
	}

	[TestFixture]
	public class LocalDateTimeTypeWithScaleFixtureAsync : DateTimeTypeWithScaleFixtureAsync
	{
		protected override string TypeName => "LocalDateTimeWithScale";
		protected override AbstractDateTimeType Type => (AbstractDateTimeType)TypeFactory.GetLocalDateTimeType(3);
	}

	[TestFixture]
	public class LocalDateTimeNoMsTypeFixtureAsync : DateTimeNoMsTypeFixtureAsync
	{
		protected override string TypeName => "LocalDateTimeNoMs";
		protected override AbstractDateTimeType Type => NHibernateUtil.LocalDateTimeNoMs;
	}
}
