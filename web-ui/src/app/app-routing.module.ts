import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlayersComponent } from './players/players.component';
import { PlayerDetailsComponent } from './player-details/player-details.component';
import { GameComponent } from './game/game.component';

const routes: Routes = [
  {
    path: '',
    component: GameComponent
  },
  {
    path: 'players',
    component: PlayersComponent
  },
  {
    path: 'player-details/:id',
    component: PlayerDetailsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
