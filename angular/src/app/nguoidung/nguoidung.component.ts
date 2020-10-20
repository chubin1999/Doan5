import { AfterViewInit, Component, OnInit, Renderer2 } from '@angular/core';

@Component({
  selector: 'app-nguoidung',
  templateUrl: './nguoidung.component.html',
  styleUrls: ['./nguoidung.component.css']
})
export class NguoidungComponent implements OnInit, AfterViewInit {

  constructor(private renderer: Renderer2) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() { 
    setTimeout(() => {
      this.loadScripts();
    });
  }
  public loadScripts() {
    this.renderExternalScript('assets/nguoidung/js/vendor/modernizr-2.8.3.min.js').onload = () => {
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
