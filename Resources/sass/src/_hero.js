import { StyleSheet } from 'react-native';

export default StyleSheet.create({
  // *
 * Explore Hero UI Components.
  'bla-hero-background': {
    'backgroundImage': 'linear-gradient(rgba(0, 0, 0, 0.45), rgba(0, 0, 0, 0.45)), url("/images/hero-background-1.jpg")',
    'backgroundPositionX': 'center',
    'backgroundPositionY': 'center',
    'backgroundSize': 'cover',
    'color': 'rgba(255, 255, 255, 0.9)',
    'transition': 'background-image 1s linear'
  },
  'bla-hero-temp': {
    'position': 'absolute',
    'top': [{ 'unit': 'px', 'value': 0 }],
    'bottom': [{ 'unit': 'px', 'value': 0 }],
    'left': [{ 'unit': 'px', 'value': 0 }],
    'right': [{ 'unit': 'px', 'value': 0 }],
    'width': [{ 'unit': '%H', 'value': 1 }],
    'height': [{ 'unit': '%V', 'value': 1 }],
    'backgroundPositionX': 'center',
    'backgroundPositionY': 'center',
    'backgroundSize': 'cover'
  },
  'bla-hero-background mdl-layout__header': {
    // This background is dark, so we set text to white. Use 87% black instead if
     your background is light.
    'color': 'white'
  },
  'bla-hero-background mdl-layout__drawer-button': {
    // This background is dark, so we set text to white. Use 87% black instead if
     your background is light.
    'color': 'white'
  },
  'bla-hero-splash': {
    'width': [{ 'unit': '%H', 'value': 1 }],
    'margin': [{ 'unit': 'px', 'value': 0 }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'px', 'value': 0 }, { 'unit': 'string', 'value': 'auto' }],
    'textAlign': 'left',
    'color': '#FFF',
    'marginTop': [{ 'unit': 'px', 'value': 50 }],
    '>w640': {
      'width': [{ 'unit': 'px', 'value': 648 }]
    }
  },
  'bla-hero-splash p': {
    'lineHeight': [{ 'unit': 'em', 'value': 1.15 }],
    'textAlign': 'center'
  },
  'bla-hero-splash pbla-hero-secondary-text': {
    'fontWeight': '300',
    'color': 'rgba(255, 255, 255, 0.75)',
    'fontSize': [{ 'unit': 'px', 'value': 18 }],
    '>w640': {
      'fontSize': [{ 'unit': 'px', 'value': 36 }]
    }
  },
  'bla-hero-splash pbla-hero-primary-text': {
    'fontWeight': '700',
    'color': 'rgba(255, 255, 255, 0.9)',
    'fontSize': [{ 'unit': 'px', 'value': 24 }],
    '>w640': {
      'fontSize': [{ 'unit': 'px', 'value': 56 }]
    }
  }
});
