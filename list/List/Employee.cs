using System;

public class Employee {

    public int Id { get; set; }
	public string Name { get; set; }
    public decimal Pay { get; private set; }

	public void addPay(decimal pay) {
		if (pay < 0) this.Pay = 0;
		else this.Pay = pay;
	}

    public void additionPay(decimal percentage) {
        if (percentage < 0 || percentage > 100)
            this.Pay = 0;
        else
            this.Pay += (this.Pay / 100) * percentage;
    }
}
