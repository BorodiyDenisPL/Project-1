#include <iostream>
#include <vector>
#include <fstream>

struct Transaction {
    std::string date;
    double amount;
    std::string category;
    std::string description;
    // Дополнительные поля или методы, если нужно
};

class MoneyTracker {
private:
    std::vector<Transaction> transactions;
    double balance;

public:
    MoneyTracker() : balance(0) {}

    void addTransaction(const Transaction& newTransaction) {
        transactions.push_back(newTransaction);
        balance += newTransaction.amount;
    }

    void deleteTransaction(int index) {
        if (index >= 0 && index < transactions.size()) {
            balance -= transactions[index].amount;
            transactions.erase(transactions.begin() + index);
        }
    }

    void displayBalance() {
        std::cout << "Current Balance: $" << balance << std::endl;
    }

    void saveToFile(const std::string& filename) {
        std::ofstream file(filename);
        if (file.is_open()) {
            for (const auto& transaction : transactions) {
                file << transaction.date << "," << transaction.amount << ","
                     << transaction.category << "," << transaction.description << "\n";
            }
            file.close();
        }
    }

    void loadFromFile(const std::string& filename) {
        std::ifstream file(filename);
        if (file.is_open()) {
            transactions.clear();
            Transaction transaction;
            while (file >> transaction.date >> transaction.amount >> transaction.category >> transaction.description) {
                transactions.push_back(transaction);
                balance += transaction.amount;
            }
            file.close();
        }
    }
};

int main() {
    MoneyTracker tracker;

    Transaction t1 = {"2023-11-20", 100.0, "Food", "Groceries"};
    tracker.addTransaction(t1);

    Transaction t2 = {"2023-11-21", -50.0, "Transport", "Bus fare"};
    tracker.addTransaction(t2);

    tracker.displayBalance();  // Проверка баланса

    tracker.deleteTransaction(0);  // Удаление первой транзакции

    tracker.displayBalance();  // Проверка баланса после удаления

    tracker.saveToFile("transactions.txt");  // Сохранение транзакций в файл

    tracker.loadFromFile("transactions.txt");  // Загрузка транзакций из файла

    tracker.displayBalance();  // Проверка баланса после загрузки из файла

    return 0;
}
