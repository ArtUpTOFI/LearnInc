import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { actionCreators } from '../store/TestStore';

class Test extends Component {
	componentWillMount() {
		// This method runs when the component is first added to the page
		this.props.requestTestRecords();
	}

	componentWillReceiveProps(nextProps) {
		// This method runs when incoming props (e.g., route params) change
		//this.props.requestTestRecords();
	}

	render() {
		return (
			<div>
				<h1>Test records</h1>
				<p>This component demonstrates nothing useful</p>
				{renderTestRecords(this.props)}
			</div>
		);
	}
}

function renderTestRecords(props) {
	return (
		<table className='table'>
			<thead>
				<tr>
					<th>Id</th>
					<th>Text</th>
				</tr>
			</thead>
			<tbody>
				{props.testRecords.map(record =>
					<tr key={record.testId}>
						<td>{record.testId}</td>
						<td>{record.testText}</td>
					</tr>
				)}
			</tbody>
		</table>
	);
}

export default connect(
	state => state.testStore,
	dispatch => bindActionCreators(actionCreators, dispatch)
)(Test);
