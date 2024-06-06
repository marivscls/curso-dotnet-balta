using Balta.NotificationContext;

namespace Libray.SharedContext;

public class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}

