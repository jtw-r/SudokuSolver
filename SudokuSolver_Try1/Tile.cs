using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Tile {
		public enum TileType {
			Empty,
			InProgress,
			Solved
		};

		public int x;
		public int y;
		public string value = "";
		public List<string> ideas = new List<string>();
		public TextBox field;
		public Panel panel;
		public bool hasField = false;

		public TileType tileType = TileType.Empty;

		public Tile(int _x, int _y, TileType _TileType, string _value, List<string> _ideas, TextBox _field, Panel _panel, bool _hasField ) {
			this.x = _x;
			this.y = _y;
			this.tileType = _TileType;
			this.value = _value;
			this.ideas = _ideas;
			this.field = _field;
			this.panel = _panel;
			this.hasField = _hasField;
		}

	}
}
