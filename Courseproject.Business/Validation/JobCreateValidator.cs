﻿using Courseproject.Common.Dtos.Address;
using Courseproject.Common.Dtos.Employee;
using Courseproject.Common.Dtos.Job;
using FluentValidation;

namespace Courseproject.Business.Validation;

public class JobCreateValidator : AbstractValidator<JobCreate>
{
	public JobCreateValidator()
	{
		RuleFor(jobCreate => jobCreate.Name).NotEmpty().MaximumLength(50);
		RuleFor(JobCreate => JobCreate.Description).NotEmpty().MaximumLength(250);
	}
}
