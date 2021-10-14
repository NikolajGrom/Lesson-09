class AirConditioning{
      
        public bool IsOn { get; private set; }
        public double Temperature { get; private set; }
        private readonly Room room;
        public double AvtoTemp { get; set; }
        public TempSensor tempSensor;


        public AirConditioning()
        {
            this.IsOn = false;
            this.Temperature = 0;
            this.AvtoTemp = 20;
            tempSensor = new TempSensor();
            room = new Room();

        }
        //public AirConditioning(Room room, bool IsOn, double Temperature)
        //{
        //this.room = new Room();
        //this.IsOn = false;
        //this.Temperature = 16;


        //}

        public void PowerOn() => this.IsOn = true;
        public void PowerOff() => this.IsOn = false;
        public void TempIncrease()=> this.Temperature++;
        public void TempDecrease() => this.Temperature--;
       
        public void ConditioningAvtoTemp(Room room)
        {
            while (AvtoTemp != room.TempRoom)
            {
                  if (AvtoTemp > room.TempRoom)
                  {
                      Temperature++;
                      room.TempRoom++;
                      System.Console.WriteLine($" Температура в комнате: " + room.TempRoom);
                  }
                  else if (AvtoTemp < room.TempRoom)
                  {
                       Temperature++;
                       room.TempRoom--;
                       System.Console.WriteLine($" Температура в комнате: " + room.TempRoom);
                  }
                
            }
       
        }
        public override string ToString()
        {
            return $"AirConditioning is {this.AvtoTemp}";
        }
        
}