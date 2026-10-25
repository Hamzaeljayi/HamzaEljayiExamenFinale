using FAQManager.DAL;
using HamzaeljayiEXOFINAL.DAL;
using HamzaeljayiEXOFINAL.Models;

namespace HamzaeljayiEXOFINAL.Bll;
public class FAQService
{
    private readonly FAQRepository _repository;

    public FAQService()
    {
        _repository = new FAQRepository();
    }

    // Récupérer toutes les FAQs
    public List<FAQItem> GetAllFAQs()
    {
        return _repository.GetAll();
    }

    // Rechercher des FAQs
    public List<FAQItem> SearchFAQs(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return _repository.GetAll();
        }

        return _repository.Search(keyword);
    }

    // Obtenir les FAQs par catégorie
    public List<FAQItem> GetFAQsByCategory(string category)
    {
        if (string.IsNullOrWhiteSpace(category))
        {
            return _repository.GetAll();
        }

        return _repository.GetByCategory(category);
    }

    // Ajouter une FAQ
    public bool AddFAQ(string question, string answer, string category)
    {
        // Validation
        if (string.IsNullOrWhiteSpace(question) ||
            string.IsNullOrWhiteSpace(answer))
        {
            return false;
        }

        var faq = new FAQItem
        {
            Question = question,
            Answer = answer,
            Category = category,
            IsActive = true,
            CreatedDate = DateTime.Now
        };

        try
        {
            _repository.Add(faq);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Supprimer une FAQ
    public bool DeleteFAQ(int id)
    {
        try
        {
            _repository.Delete(id);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Obtenir toutes les catégories
    public List<string> GetAllCategories()
    {
        return _repository.GetCategories();
    }

    // Obtenir le nombre total de FAQs
    public int GetTotalFAQCount()
    {
        return _repository.GetAll().Count;
    }

    // Statistiques par catégorie
    public Dictionary<string, int> GetFAQCountByCategory()
    {
        return _repository.GetAll()
            .GroupBy(f => f.Category)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}
