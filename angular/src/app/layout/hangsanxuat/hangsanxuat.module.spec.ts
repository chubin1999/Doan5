import { HangsanxuatModule } from './hangsanxuat.module';

describe('TablesModule', () => {
  let tablesModule: HangsanxuatModule;

  beforeEach(() => {
    tablesModule = new HangsanxuatModule();
  });

  it('should create an instance', () => {
    expect(HangsanxuatModule).toBeTruthy();
  });
});
