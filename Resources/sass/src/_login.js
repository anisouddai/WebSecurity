import { StyleSheet } from 'react-native';

export default StyleSheet.create({
  // *
 * SafetyMeasure App Login UI Components. 
 * Based on     MDL Text Fields: https://getmdl.io/components/index.html#textfields-section
 *              MDL Buttons: https://getmdl.io/components/index.html#buttons-section
  'bla-remember-me-checkbox': {
    'marginTop': [{ 'unit': 'px', 'value': 25 }]
  },
  'mdl-textfield--floating-label': {
    'color': '#000000 !important'
  },
  'mdl-button--file input': {
    'cursor': 'pointer',
    'height': [{ 'unit': '%V', 'value': 1 }],
    'right': [{ 'unit': 'px', 'value': 0 }],
    'opacity': '0',
    'position': 'absolute',
    'top': [{ 'unit': 'px', 'value': 0 }],
    'width': [{ 'unit': 'px', 'value': 300 }],
    'zIndex': '4'
  },
  'mdl-textfield--file mdl-textfield__input': {
    'boxSizing': 'border-box',
    'width': [{ 'unit': '%H', 'value': NaN }]
  },
  'mdl-textfield--file mdl-button--file': {
    'right': [{ 'unit': 'px', 'value': 0 }]
  },
  '#login-footer': {
    'display': 'grid',
    'marginTop': [{ 'unit': '%V', 'value': 0.1 }]
  },
  '#sign-in': {
    'textDecoration': 'none',
    'marginTop': [{ 'unit': 'px', 'value': 20 }],
    'textAlign': 'center',
    'color': '#6200FF'
  }
});
