using Mapperly.Nullable;

Car car = new()
{
    Model = "Model",
    Descriptions = new List<string> { "Sunroof" }
};

CarDto carDto = car.CarToCarDto();

Console.WriteLine($"Hello {carDto.Model}");