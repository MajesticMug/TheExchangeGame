import { Component, OnInit } from '@angular/core';
import { PlayerService } from '../player.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.scss']
})
export class PlayersComponent implements OnInit {
  players$: Object;

  constructor(private service: PlayerService) { }

  ngOnInit() {
    this.service.getPlayers().subscribe(
      data => this.players$ = data
    );
  }

}
