using UnityEngine;

namespace Logic
{
    public class Drag : MonoBehaviour
	{
		public Vector3 MousePosition { get; set; }
		public Transform Dragging { get; set; }
		public Vector3 Offset { get; set; }
		[SerializeField]
		public LayerMask movableLayers;

		void Start()
		{
			Dragging = null;
		}

		void Update()
		{
			MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit2D hit = Physics2D.Raycast(MousePosition,
					new Vector2(0, 0),
					10,
					movableLayers);

				if (hit)
				{
					Dragging = hit.transform;

					Offset = Dragging.position - MousePosition;
				}
			}
			else if (Input.GetMouseButtonUp(0))
			{
				Dragging = null;
			}

			if (Dragging)
			{
				Dragging.position = MousePosition + Offset;
			}
		}
	}
}