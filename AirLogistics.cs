namespace Factory
{
    class AirLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Plane();

    }
}