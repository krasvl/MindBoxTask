## Задание 2

### Product
| Id | Name |

### Categorie
| Id | Name |

### ProductCategorie
| Id | ProductId | CategorieId |


SELECT Product.Name AS ProductName, Categorie.Name AS CategorieName FROM Product

LEFT JOIN ProductCategorie ON Product.Id = ProductCategorie.ProductId

LEFT JOIN Categorie ON Categorie.Id = ProductCategorie.CategorieId
