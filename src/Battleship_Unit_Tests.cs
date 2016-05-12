using NUnit.Framework;
using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace Application
{
	[TestFixture ()]
	public class Battleship_Unit_Tests
	{
		[Test ()]
		public void TestAddTile()
		{
			// ARRANGE //
			Ship shipD = new Ship(new ShipName());
			Tile tiles12 = new Tile (25, 25, shipD);
			List<Tile> tiles = new List<Tile>{tiles12};
			// ACT //
			tiles.Add(new Tile(80,75, shipD));

			// ASSERT //
			Assert.IsNotEmpty(tiles);

		}
		public void TestIsShipDeployed()
		{
			// ARRANGE //
			Ship shipD = new Ship(new ShipName());
			Tile tiles  = new Tile (25, 25, shipD);
			//Direction dire = Direction.LeftRight;

			// ACT //
			shipD.Deployed(shipD.Direction= Direction.LeftRight, shipD.Row = 25, shipD.Column = 25);
			shipD.AddTile(tiles);

			// ASSERT //
			Assert.IsTrue(shipD.IsDeployed);
		}

		public void TestRemoveTile()
		{
			// ARRANGE //
			Ship shipD = new Ship(new ShipName());
			Tile tiles1 = new Tile (25, 25, shipD);
			List<Tile> tiles = new List<Tile>{tiles1};
			// ACT //
			tiles.Remove(tiles1);

			// ASSERT //
			Assert.IsEmpty(tiles);

		}
	}
}

