﻿namespace LaharaGame.GameObjects.Characters.EnemyClasses
{
    using Microsoft.Xna.Framework;

    class Sorceror : Enemy
    {
        private const string SpriteTexturePath = "monsters";
        private const string Type = "sorceror";

        private const int textureWidth = 32;
        private const int textureHeight = 32;

        private const int DefaultHealthPoints = 70;
        private const int DefaultAttackPoints = 5;
        private const int DefaultDefensePoints = 1;
        private const int DefaultRange = 1;
        private const int DefaultStepSize = 1;


        public Sorceror(Vector2 position)
            : base(
                  SpriteTexturePath,
                  Type,
                  position,
                  DefaultHealthPoints,
                  DefaultAttackPoints,
                  DefaultDefensePoints,
                  DefaultRange,
                  DefaultStepSize,
                  textureHeight,
                  textureWidth)
        {
        }
    }
}
