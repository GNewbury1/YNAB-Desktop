# YNAB Desktop Client

This client makes use of YNAB [api/v1](https://api.youneedabudget.com/)

**Security Warning:** This client currently stores your access token as plaintext. This will be removed in later versions. This is a testing version only.
The relevant bit of code is this, found in Ynab_Account.cs (`Ynab_account.writeTokenToFile`)
```c#
private void writeTokenToFile()
        {
            System.IO.File.WriteAllText("access.token", this.accessToken);
        }
```


## Added Features:
- Get all budgets

## Upcoming features:
- View specific budgets
- View accounts
- View spending per category/payee
- View spending over a period of time
- View income/expenses
