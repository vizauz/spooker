﻿//-----------------------------------------------------------------------------
// IUpdateable.cs
//
// Spooker Open Source Game Framework
// Copyright (C) Indie Armory. All rights reserved.
// Website: http://indiearmory.com
// Other Contributors: None
// License: MIT
//-----------------------------------------------------------------------------

using Spooker.Time;

namespace Spooker
{
	////////////////////////////////////////////////////////////
	/// <summary>
	/// Interface used for updateable objects
	/// </summary>
	////////////////////////////////////////////////////////////
    public interface IUpdateable
    {
		/// <summary>
		/// Component uses this for updating itself.
		/// </summary>
		/// <param name="gameTime">Provides snapshot of timing values.</param>
		void Update(GameTime gameTime);
    }
}