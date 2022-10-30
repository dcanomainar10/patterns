
using oscarblancarte.ipd.visitor.domain;
using System;
using System.Collections.Generic;

namespace oscarblancarte.ipd.visitor.impl{
    public class PaymentProjectVisitor : IVisitor {

        private Dictionary<string, double> employeePayment = new Dictionary<string, double>();

        public void Project(Project project) {
            foreach (Activitie act in project.Activities) {
                act.accept(this);
            }
        }

        public void Activitie(Activitie activitie) {
            activitie.Responsible.accept(this);
            foreach (Activitie act in activitie.Activities) {
                act.accept(this);
            }
        }

        public void Employee(Employee employee) {
            string resp = employee.Name;
            if (employeePayment.ContainsKey(resp)) {
                employeePayment[resp] = employeePayment[resp] + employee.Price;
            } else {
                employeePayment.Add(resp, employee.Price);
            }
        }

        public Object GetResult() {
            List<EmployeePay> response = new List<EmployeePay>();

            foreach (string key in employeePayment.Keys) {
                response.Add(new EmployeePay(key, employeePayment[key]));
            }
            return response;
        }

    }
}