using Riok.Mapperly.Abstractions;

namespace Mapperly.Nullable;

[Mapper]
public static partial class DtoMapper
{
    public static partial CarDto CarToCarDto(this Car car);
}