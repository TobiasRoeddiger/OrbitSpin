public class OrbitSpin {

	private Stopwatch _stopwatch;
	
    private const int RotationTime = 2500; //in ms
    private const double _ballRadius = 20.0;
    private const double _swingRadius = 20.0;
    private const double _centerX = 20.0;
    private const double _centerY = 20.0;
        
	public OrbitSpin()
	{
		_stopwatch = new Stopwatch();
    	_stopwatch.Start();
    	        
		var timer = new Timer();
    	timer.Tick += (sender, args) => { MakeSpinStep(); };
    	timer.Interval = 20; //call every 20 ms
    	timer.Start();
	}

	private void MakeSpinStep()
	{
	    var elapsedTime = _stopwatch.ElapsedMilliseconds;
	
	    var theta = Math.PI * 2f * elapsedTime / RotationTime;
	
		var ballCenterX = _centerX + _swingRadius * Math.Cos(theta);
	  	var ballCenterY = _centerY + _swingRadius * Math.Sin(theta);
	
	  	var ballLeft = ballCenterX - _ballRadius;
	  	var ballTop = ballCenterY - _ballRadius;
	
	  	//TODO: set top and left of the spinning trajectory
	}
}