import { fuwoTemplatePage } from './app.po';

describe('fuwo App', function() {
  let page: fuwoTemplatePage;

  beforeEach(() => {
    page = new fuwoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
