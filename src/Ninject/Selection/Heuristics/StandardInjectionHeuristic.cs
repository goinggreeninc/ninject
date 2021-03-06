#region License
// 
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2007-2009, Enkari, Ltd.
// 
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
// 
#endregion
#region Using Directives
using System;
using System.Reflection;
using Ninject.Components;
using Ninject.Infrastructure;
using Ninject.Infrastructure.Language;
#endregion

namespace Ninject.Selection.Heuristics
{
	/// <summary>
	/// Determines whether members should be injected during activation by checking
	/// if they are decorated with an injection marker attribute.
	/// </summary>
	public class StandardInjectionHeuristic : NinjectComponent, IInjectionHeuristic
	{
		/// <summary>
		/// Returns a value indicating whether the specified member should be injected.
		/// </summary>
		/// <param name="member">The member in question.</param>
		/// <returns><c>True</c> if the member should be injected; otherwise <c>false</c>.</returns>
		public bool ShouldInject(MemberInfo member)
		{
			Ensure.ArgumentNotNull(member, "member");
			return member.HasAttribute(Settings.InjectAttribute);
		}
	}
}