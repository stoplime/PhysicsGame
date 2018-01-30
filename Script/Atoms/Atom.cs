using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom {
	public string AtomName;

	public float AtomSize = 1;

	public int NumberAttachmentPoints = 1;

	/// <summary>
	/// A list of attachment point in unit vectors where the (0,0,0) is the center of the atom.
	/// </summary>
	private List<Vector3> AttachmentLocations;
}
