//using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;



using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    internal class VideoEncoder
    {
        public VideoEncoder()
        {
            private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder() => _notificationChannels = new List<INotificationChannel>();
        public void Encode(Video video)
        {
            //Video encoding logic
            //....
            foreach (var channel in _notificationChannels) // Here is a polymorphic behaviour 
            {
                channel.Send(new Message());
            }
        }

        public void RegistrationNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
    }
}