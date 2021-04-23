import { TypingDashboardTemplatePage } from './app.po';

describe('TypingDashboard App', function() {
  let page: TypingDashboardTemplatePage;

  beforeEach(() => {
    page = new TypingDashboardTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
