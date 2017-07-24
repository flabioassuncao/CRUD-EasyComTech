import { GTEPage } from './app.po';

describe('gte App', () => {
  let page: GTEPage;

  beforeEach(() => {
    page = new GTEPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
