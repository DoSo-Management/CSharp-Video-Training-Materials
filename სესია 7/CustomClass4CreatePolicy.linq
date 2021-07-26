<Query Kind="Program" />

void Main()
{
	var motorPolicy = new MotorPolicy { PolicyNumber = "PN1", MotorPolicyProperty = "MP1" }.Dump();
	var customClass4MotorPolicy = new CustomClass4CreatePolicy_Motor { ParentPolicy = motorPolicy }.Dump();
}

public abstract class CustomClass4CreatePolicy<T>
	where T : PolicyBase
{
	public T ParentPolicy { get; set; }

	public virtual void AccessAvailableProperty()
	{
		ParentPolicy.PolicyNumber.Dump();
		// ParentPolicy.PolicyNumber.Dump();

	}
}

public class CustomClass4CreatePolicy_Motor : CustomClass4CreatePolicy<MotorPolicy>
{
	public void AccessMotorPolicyProperty()
	{
		var motorPolicyProperty = ParentPolicy.MotorPolicyProperty;
	}

	public override void AccessAvailableProperty()
	{
		base.AccessAvailableProperty();
		
		ParentPolicy.MotorPolicyProperty.Dump();
	}
}

public class MotorPolicy : PolicyBase
{
	public string MotorPolicyProperty { get; set; }
}

public class TPLPolicy : PolicyBase
{
	public string TPLPolicyProperty { get; set; }
}

public abstract class PolicyBase
{
	public string PolicyNumber { get; set; }
}
