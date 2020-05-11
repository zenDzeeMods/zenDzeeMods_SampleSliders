using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using zenDzeeMods;

namespace zenDzeeMods_SampleSliders
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;

                campaignStarter.AddBehavior(new ChangeFacesBehavior());
            }
        }
    }

    internal class ChangeFacesBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickPartyEvent.AddNonSerializedListener(this, OnHourlyTickPartyEvent);
        }

        private void OnHourlyTickPartyEvent(MobileParty mobileParty)
        {
            if (mobileParty.IsLordParty && mobileParty.LeaderHero != null)
            {
                ChangeFaceRandomly(mobileParty.LeaderHero);
            }
        }

        private void ChangeFaceRandomly(Hero hero)
        {
            BodySliders heroBodySliders = new BodySliders(hero.BodyProperties.StaticProperties);

            byte v = heroBodySliders.EyeAsymmetry;
            v = (byte)(v > 0 ? 0 : 15);

            heroBodySliders.EyeAsymmetry = v;
            heroBodySliders.NoseAsymmetry = v;
            heroBodySliders.FaceAsymmetry = v;

            heroBodySliders.FaceWidth = v;
            heroBodySliders.FaceTempleWidth = v;
            heroBodySliders.FaceCheekboneWidth = v;

            BodyProperties newBodyProperties = new BodyProperties(hero.DynamicBodyProperties, heroBodySliders.GetStaticBodyProperties());

            BasicCharacterObject tmp = Game.Current.PlayerTroop;
            Game.Current.PlayerTroop = hero.CharacterObject;
            hero.CharacterObject.UpdatePlayerCharacterBodyProperties(newBodyProperties, hero.IsFemale);
            Game.Current.PlayerTroop = tmp;

        }

        public override void SyncData(IDataStore dataStore)
        {
        }
    }
}
