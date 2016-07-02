using UnityEngine;

namespace CoolestTween {

	public class TrPositionTweener : AbstractTweener<Vector3> {

		private Transform transform;
		private Vector3 value;

		public TrPositionTweener(Transform transform, Vector3 to){
			this.transform = transform;
			this.From = transform.position;
			this.To = to;
		}

		public override void Update(float v) {
			Vector3 diff = To-From;
			value.x = Ease(v, From.x, diff.x, Duration);
			value.y = Ease(v, From.y, diff.y, Duration);
			value.z = Ease(v, From.z, diff.z, Duration);
			transform.position = value;
		}
	}
}