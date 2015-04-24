﻿using Sidewalk.WFFMExtension.Helpers;
using Sidewalk.WFFMExtension.Resources;
using Sitecore.Form.Core.Validators;

namespace Sidewalk.WFFMExtension.Validators
{
    public class CustomCountCharsValidator : CountCharsValidator
    {
        protected override bool EvaluateIsValid()
        {
            if (WFFMExtensionHelper.IsDisplayNone(Parent))
            {
                return true;
            }

            return base.EvaluateIsValid();

        }
    }
}
