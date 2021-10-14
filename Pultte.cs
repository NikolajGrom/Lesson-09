class Pultte
    {
      

        public delegate void AirConditioningState(string text);
        public event AirConditioningState Notify;
      

        private readonly AirConditioning airConditioning;
        public Pultte(AirConditioning airConditioning)
        {
            this.airConditioning = airConditioning;   
        }

        public void PowerConditioning_Off() {
            this.airConditioning.PowerOff();
            this.Notify?.Invoke($"{System.DateTime.Now.ToShortTimeString()}:\twas switch off");
        }

        public void PowerConditioning_On() {
            this.airConditioning.PowerOn();
            this.Notify?.Invoke($"{System.DateTime.Now.ToShortTimeString()}:\twas switch on");
        }


        public void IncreaseTemp()
        {
            this.airConditioning.TempIncrease();
            this.Notify?.Invoke($" temp: { this.airConditioning.Temperature} ");
        }
        public void DecreaseTemp()
        {
            this.airConditioning.TempDecrease();
            this.Notify?.Invoke($" temp: { this.airConditioning.Temperature} ");

        }
       



        public override string ToString()
        {
            return $"AirConditioning is {this.airConditioning.IsOn}";
        } 

    }