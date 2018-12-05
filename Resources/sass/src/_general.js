import { StyleSheet } from 'react-native';

export default StyleSheet.create({
  // *
 * SafetyMesure App General UI Components.
  'mdl-layout__container': {
    'backgroundColor': '#f6f9ff'
  },
  'coming-soon-wrapper': {
    'width': [{ 'unit': '%H', 'value': 1 }]
  },
  'mdl-center': {
    'margin': [{ 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }],
    'width': [{ 'unit': '%H', 'value': 0.5 }]
  },
  '#role-container': {
    'margin': [{ 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }],
    'width': [{ 'unit': '%H', 'value': 0.5 }]
  },
  '#login-container': {
    'margin': [{ 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }, { 'unit': 'string', 'value': 'auto' }],
    'width': [{ 'unit': '%H', 'value': 0.5 }]
  },
  'mdl-center mdl-button--accent': {
    'backgroundColor': '#6200FF !important'
  },
  '#role-container mdl-button--accent': {
    'backgroundColor': '#6200FF !important'
  },
  '#login-container mdl-button--accent': {
    'backgroundColor': '#6200FF !important'
  },
  '#role-actions': {
    'display': 'flex',
    'justifyContent': 'space-between'
  },
  '#content-wrapper mdl-button': {
    'color': '#6200FF'
  }
});
