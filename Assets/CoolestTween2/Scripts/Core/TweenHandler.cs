namespace CoolestTween {

	public class TweenHandler {

		private Tween tween;

		public bool IsComplete {
			get{
				return tween.IsComplete;
			}
		}

		public bool IsPause {
			get {
				return tween.IsPause;
			}
		}

		public bool InDelay {
			get{
				return tween.InDelay;
			}
		}

		public TweenHandler(){
		}

		public TweenHandler(Tween tween){
			SetTween(tween);
		}

		public void SetTween(Tween tween){
			this.tween = tween;
		}

		public void Pause(){
			tween.Pause();
		}

		public void Resume(){
			tween.Resume();
		}
	}
}