﻿using MediatR;

using System.Threading.Tasks;

namespace PresenceLight.Core.WizServices
{
    public class SetColorCommand : IRequest<Unit>
    {
        public string Availability { get; set; }
        public string Activity { get; set; }
        public string LightID { get; set; }
    }
}
