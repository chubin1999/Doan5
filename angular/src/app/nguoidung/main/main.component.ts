import { AfterViewInit, Component, OnInit, Renderer2, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { SanphamService } from '../../shared/services/sanpham.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit, AfterViewInit {
  @ViewChild('AddEditModal', { static: false }) AddEditModal: ModalDirective;
  constructor(private renderer: Renderer2 , private sanphamService: SanphamService) { }
  public items: any[];
  ngOnInit(): void {
    this.loadData();
  }
  loadData() {
    this.sanphamService.getLink().subscribe((res: any) => {
        this.items = res;
    });
}

  ngAfterViewInit() {
    setTimeout(() => {
      this.loadScripts();
    });
  }
  public loadScripts() {
    this.renderExternalScript('assets/nguoidung/js/main.js').onload = () => {
    }
  }
  public renderExternalScript(src: string): HTMLScriptElement {
    const script = document.createElement('script');
    script.type = 'text/javascript';
    script.src = src;
    script.async = true;
    script.defer = true;
    this.renderer.appendChild(document.body, script);
    return script;
  }
}
