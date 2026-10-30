using System;
using NUnit.Framework;

namespace Pkmn.Tests
{
    public class FightMoreTests
    {
        [Test]
        public void healNoMoreMaxheal()
        {
            Character pikachu = new Character(100, 50, 30, 20, TYPE.NORMAL);
            Skill punch = new Punch();
            pikachu.ReceiveAttack(punch);
            pikachu.Heal(500);
            Assert.That(pikachu.CurrentHealth, Is.EqualTo(pikachu.MaxHealth));
        }
        [Test]
        public void RemoveHpMax()
        {
            Character pikachu = new Character(100, 50, 30, 20, TYPE.NORMAL);
            pikachu.RemoveHPMax(50);
            Assert.That(pikachu.MaxHealth, Is.EqualTo(50));
            Assert.That(pikachu.CurrentHealth, Is.EqualTo(50));
        }
        // Tu as probablement remarqué qu'il y a encore beaucoup de code qui n'a pas été testé ...
        // À présent c'est à toi de créer des features et les TU sur le reste du projet

        // Ce que tu peux ajouter:
        // - Ajouter davantage de sécurité sur les tests apportés
        // - ajouter un equipement qui rend les attaques prioritaires puis l'enlever et voir que l'attaque n'est plus prioritaire etc)
        // - Le support des status (sleep et burn) qui font des effets à la fin du tour et/ou empeche le pkmn d'agir
        // - Gérer la notion de force/faiblesse avec les différentes attaques à disposition (skills.cs)
        // - Cumuler les force/faiblesses en ajoutant un type pour l'équipement qui rendrait plus sensible/résistant à un type
        // - L'utilisation d'objets : Potion, SuperPotion, Vitess+, Attack+ etc.
        // - Gérer les PP (limite du nombre d'utilisation) d'une attaque,
        // si on selectionne une attack qui a 0 PP on inflige 0

        // Choisis ce que tu veux ajouter comme feature et fait en au max.
        // Les nouveaux TU doivent être dans ce fichier.
        // Modifiant des features il est possible que certaines valeurs
        // des TU précédentes ne matchent plus, tu as le droit de réadapter les valeurs
        // de ces anciens TU pour ta nouvelle situation.

    }
}
